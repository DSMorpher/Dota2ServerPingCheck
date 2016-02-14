using System;
using System.Configuration;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Dota2ServerPingCheck
{
    public class ServerStatus
    {
        private long _ping = int.MaxValue;
        private double _packetLoss = 100;
        private int _totalPacketsSent;
        private int _totalPacketsReceived;
        private long _totalRoundTripTime;
        private readonly object _lock = new object();

        public const int NormalTries = 5;
        public const int DetailTries = 50;
        public const int Timeout = 2000;

        public static EventHandler OnUpdateData;
        public static EventHandler OnConsoleWrite;

        public long Ping
        {
            get { return _ping; }
            set { _ping = value; }
        }

        public double PacketLoss
        {
            get { return _packetLoss; }
            set { _packetLoss = value; }
        }

        public int TotalPacketsSent
        {
            get { return _totalPacketsSent; }
            set { _totalPacketsSent = value; }
        }

        public int TotalPacketsReceived
        {
            get { return _totalPacketsReceived; }
            set { _totalPacketsReceived = value; }
        }

        public long TotalRoundTripTime
        {
            get { return _totalRoundTripTime; }
            set { _totalRoundTripTime = value; }
        }

        private void ResetStats()
        {
            _totalPacketsReceived = 0;
            _totalPacketsSent = 0;
            _totalRoundTripTime = 0;
        }

        internal void RefreshPing(Dota2Server server, bool isDetailed)
        {
            try
            {
                lock (_lock)
                {
                    ResetStats();
                    int tries = isDetailed ? DetailTries : NormalTries;

                    Ping pingSender = new Ping();
                    for (int i = 0; i < tries; i++)
                    {
                        _totalPacketsSent++;
                        PingReply reply = pingSender.Send(server.Address, Timeout);

                        if (reply != null && reply.Status == IPStatus.Success)
                        {
                            _totalPacketsReceived++;
                            _totalRoundTripTime += reply.RoundtripTime;
                        }
                    }
                    if (_totalPacketsReceived > 0)
                    {
                        _ping = (_totalRoundTripTime / _totalPacketsReceived);
                    }
                    else
                    {
                        _ping = int.MaxValue;
                    }
                    if (_totalPacketsSent > 0)
                    {
                        _packetLoss = CalculatePacketLoss();
                    }
                    else
                    {
                        _packetLoss = 100;
                    }
                    if (isDetailed)
                    {
                        MessageBox.Show("Server Name \t\t = " + server.Name + "\r\n"
                                        + "Total Packets sent \t\t = " + _totalPacketsSent + " packets \r\n"
                                        + "Total Packets Received \t = " + _totalPacketsReceived + " packets \r\n"
                                        + "Total Time taken \t\t = " + _totalRoundTripTime + " mili-Seconds \r\n"
                                        + "Average Ping \t\t = " + _ping + " mili-Seconds \r\n"
                                        + "Packet Loss \t\t = " + _packetLoss + " % \r\n"
                            , "Detail Ping Results", MessageBoxButtons.OK);
                    }
                    ConsoleWrite("Request ping " + server.Name + " Completed.", Color.Lime);
                }
            }
            catch (Exception e)
            {
                _ping = int.MaxValue;
                _packetLoss = 100;
                if (ConfigurationSettings.AppSettings["IsErrorEnabled"] == "true")
                    ConsoleWrite("Error occured while requesting ping " + server.Name + " " + e, Color.Red);
                else
                    ConsoleWrite("Error occured while requesting ping " + server.Name + " " + e.Message, Color.Red);
            }
            ResetStats();
            UpdateData();
        }

        public static void UpdateData()
        {
            if (OnUpdateData != null)
                OnUpdateData(null, new EventArgs());
        }

        public static void ConsoleWrite(string data, Color color)
        {
            if (OnConsoleWrite != null)
                OnConsoleWrite(new object[] { data, color }, new EventArgs());
        }

        private double CalculatePacketLoss()
        {
            double loss = 100 - (((double)_totalPacketsReceived / _totalPacketsSent) * 100);

            if (loss < 0)
                return 0;

            if (loss > 100)
                return 100;

            return loss;

        }
    }
}

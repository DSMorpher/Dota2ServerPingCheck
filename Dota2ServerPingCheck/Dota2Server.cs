using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2ServerPingCheck
{
    class Dota2Server
    {
        private string _name = "";
        public long _ping = int.MaxValue;
        private string _address = "";
        public int _packetLoss = 100;
        public int TotalPacketsSent = 0;
        public int TotalPacketReceived = 0;
        public long TotalRoundTripTime = 0;

        public string Name
        {
            get { return _name; }
        }

        public string Address
        {
            get { return _address; }
        }

        public long Ping
        {
            get { return _ping; }
            //set { _ping = value; }
        }

        public int PacketLoss
        {
            get { return _packetLoss; }
            //set { _packetLoss = value; }
        }

        //public int TotalPacketsSent { get; set; }
        //public long TotalRoundTripTime { get; set; }

        public Dota2Server(string address, string name)
        {
            _address = address;
            _name = name;
        }

    }
}

using System;
using System.ComponentModel;
using System.Threading;

namespace Dota2ServerPingCheck
{
    class Dota2Server
    {
        private string _name = "";
        private string _address = "";
        private ServerStatus _status;

        public string Name
        {
            get { return _name; }
        }

        public string Address
        {
            get { return _address; }
        }

        [Browsable(false)]
        public ServerStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        [DisplayName("Ping (mili-Seconds)")]
        public long Ping
        {
            get
            {
                if (_status != null)
                    return _status.Ping;
                
                return int.MaxValue;
            }
        }

        [DisplayName("Packet Loss (%)")]
        public double PacketLoss
        {
            get
            {
                if (_status != null)
                    return Math.Round(_status.PacketLoss, 2);
                
                return Math.Round(100d, 2);
            }
        }

        public Dota2Server(string address, string name)
        {
            _address = address;
            _name = name;
            _status = new ServerStatus();
        }

        public void RefreshPing(bool isDetailed)
        {
            if (_status != null)
            {
                ThreadPool.QueueUserWorkItem(RefreshPingInternal, isDetailed);
            }
        }

        private void RefreshPingInternal(object isDetail)
        {
            if (_status != null)
            {
                _status.RefreshPing(this, (bool)isDetail);
            }
        }
    }
}

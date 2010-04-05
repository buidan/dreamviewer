using System;
using System.Collections.Generic;
using System.Text;

namespace VLCTestApp.Settings
{
    [Serializable]
    class Settings
    {
        string rtmpAddress;

        public string RtmpAddress
        {
            get { return rtmpAddress; }
            set { rtmpAddress = value; }
        }
        string epgAddress;

        public string EpgAddress
        {
            get { return epgAddress; }
            set { epgAddress = value; }
        }
        string next, prev, full, info, chan;

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public string Full
        {
            get { return full; }
            set { full = value; }
        }

        public string Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public string Next
        {
            get { return next; }
            set { next = value; }
        }

        public string Chan
        {
            get { return chan; }
            set { chan = value; }
        }
        string addr;
        string port;

        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }

        public string Port
        {
            get { return port; }
            set { port = value; }
        }
    }
}

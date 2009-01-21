using System;
using System.Collections.Generic;
using System.Text;

namespace VLCTestApp.Settings
{
    class Settings
    {
        string addr;
        int port;

        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }
    }
}

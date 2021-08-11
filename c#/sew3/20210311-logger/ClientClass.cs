using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210311_logger
{
    class ClientClass
    {
        private ILogger logger;

        public ILogger Logger
        {
            set { logger = value; }
        }

        public ClientClass()
        {

        }

        public ClientClass(ILogger logger)
        {
            this.logger = logger;
        }

        public void ProcessInfo(string info)
        {
            if (logger != null) logger.LogInfo(info);
            else throw new NullReferenceException("kein logger angeschlossen");

        }
    }
}

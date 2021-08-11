using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210311_logger
{
    class FileLogger : ILogger
    {
        private readonly string path;
        public FileLogger(string path)
        {
            if (String.IsNullOrEmpty(path)) throw new NullReferenceException("No path was handed!");
            this.path = path;
        }

        void ILogger.LogInfo(string info)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                info = "Start Log at " + DateTime.Now + Environment.NewLine + info;
                file.WriteLine(info);
            }
        }
    }
}

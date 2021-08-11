using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210311_logger
{
    class WindowLogger : ILogger
    {
        private System.Windows.Forms.ListBox logBox;
        public WindowLogger(object control)
        {
            logBox = control as System.Windows.Forms.ListBox;
            if (logBox == null) throw new NullReferenceException("Control is no ListBox!");
        }
        void ILogger.LogInfo(string info)
        {
            if (logBox == null) throw new NullReferenceException("Control ist missing!");
            else
            {
                info = "Start Log at " + DateTime.Now + ": " + info;
                logBox.Items.Add(info);
            }
        }
    }
}

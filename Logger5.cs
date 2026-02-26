using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_5
{
    internal class Logger
    {
        public Action<string> LogHandler;
        public void Log(string message)
        {
            if (LogHandler != null)
            {
                LogHandler(message);
            }
        }
    }
}

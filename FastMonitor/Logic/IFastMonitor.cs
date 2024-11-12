using FastMonitor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMonitor.Logic
{
    internal interface IFastMonitor
    {
        bool CheckAccess(User user, int dataId);
        void LogAccessAttempt(User user, int dataId);

    }
}

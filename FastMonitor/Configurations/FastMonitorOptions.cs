using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMonitor.Configurations
{
   public class FastMonitorOptions
    {
        public bool RequireRoleBasedAccess { get; set; } = true;
        public bool LogAllAccessAttempts { get; set; } = true;
    }
}

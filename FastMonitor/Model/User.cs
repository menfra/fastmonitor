using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMonitor.Model
{
    public class User
    {
        public int Id { get; set; }

        // Example method that would check the user's permissions
        public bool HasPermission(int dataId)
        {
            // Placeholder logic for checking permission
            return true;
        }
    }
}

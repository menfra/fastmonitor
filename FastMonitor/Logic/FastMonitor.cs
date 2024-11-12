using FastMonitor.Model;
using System;

namespace FastMonitor.Logic
{
    public class FastMonitorService : IFastMonitor
    {
        public bool CheckAccess(User user, int dataId)
        {
            // Add logic to verify if user has permissions for dataId
            // Replace this with actual authorization logic
            return user.HasPermission(dataId);
        }

        public void LogAccessAttempt(User user, int dataId)
        {
            // Log access attempt for auditing
            Console.WriteLine($"User {user.Id} accessed data {dataId} at {DateTime.UtcNow}");
        }
    }
}
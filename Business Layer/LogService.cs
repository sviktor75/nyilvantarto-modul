using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace BusinessLayer
{
    public class LogService : ILogService
    {
        public LogService()
        {
            Log.Information("Application startup.");
        }
        void ILogService.Create(string message)
        {
            {
                Log.Information(message);
            }
        }
    }
}

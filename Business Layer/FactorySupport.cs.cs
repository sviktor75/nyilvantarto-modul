using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Interfaces;
using LiteDB;
using Serilog;


namespace BusinessLayer
{
    public class FactorySupport
    {
        private IDataService dataService;
        

        public FrameWork Create(bool isMySQL, LiteRepository repo)
        {
            dataService = new DataService(isMySQL, repo);
            ILogService logService = new LogService();
            IErrorService errorService = new ErrorService();
            FrameWork frameWork = new FrameWork(dataService, logService, errorService);
            return frameWork;
        }
    }
}

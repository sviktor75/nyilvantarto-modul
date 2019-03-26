using BusinessLayer.Interfaces;
using Common;
using Common.Interfaces;
using DataLayer.Interfaces;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FrameWork
    {
        private IDataService dataService;
        private ILogService logService;
        private IErrorService errorService;
        private IRegisterActive registerActive;

        public FrameWork(IDataService dataService, ILogService logService, IErrorService errorService)
        {
            this.dataService = dataService;
            this.logService = logService;
            this.errorService = errorService;
            registerActive = new RegisterActive(logService);
        }
        
        public IError AddItemActive(IItemActive item)
        {
            IError error = registerActive.Add(item);

            return error;
        }
        public IItemActive GetItemByID(int id)
        {
             IItemActive item = registerActive[id];

            return item;
        }
    }
}

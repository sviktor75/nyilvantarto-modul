using BusinessLayer.Interfaces;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ErrorService : IErrorService
    {
        void IErrorService.Write(IError error)
        {
            throw new NotImplementedException();
        }
    }
}

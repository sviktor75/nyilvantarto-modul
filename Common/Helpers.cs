using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Models;

namespace Common
{
    public static class Helpers
    {
        public static IError ErrorMessage(ErrorType errorType, string errorMessage = "")
        {
            IError error = new Error(errorType, errorMessage);
            return error;
        }
    }

    public enum ErrorType
    {
        NoError = 0,
        DatabaseError,
        InputError,
        NoUniqueID,
        NoItem
    }

    public enum ConnectorType
    {
        Single,
        Double,
        Rated
    }
}

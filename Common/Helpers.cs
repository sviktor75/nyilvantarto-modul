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
        private static int actualItemID;
        private static int actualLocationID;
        private static int actualPortID;
        private static int actualConnectionID;
        private static int actualConnectorWallID;

        public static int GenerateItemtID()
        {
            actualItemID++;
            return actualItemID;
        }

        public static int GenerateLocationID()
        {
            actualLocationID++;
            return actualLocationID;
        }

        public static int GeneratePortID()
        {
            actualPortID++;
            return actualPortID;
        }

        public static int GenerateConnectionID()
        {
            actualConnectionID++;
            return actualConnectionID;
        }

        public static int GenerateConnectorWallID()
        {
            actualConnectorWallID++;
            return actualConnectorWallID;
        }

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

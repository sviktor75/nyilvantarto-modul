﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;

namespace Common.Models
{
    class PortTypePassive
    {
        private HashSet<string> portName = new HashSet<string>();

        public string this[string name]
        {
            get
            {
                return portName.Where(item => item == name).FirstOrDefault();
            }
        }

        IError AddPortType(string portTypeName)
        {

            if (portName.Contains(portTypeName))
            {
                return Helpers.ErrorMessage(ErrorType.NoUniqueID,
                    "Ilyen típusú port már létezik");
            }
            else
            {
                portName.Add(portTypeName);
                return Helpers.ErrorMessage(ErrorType.NoError);
            }
        }

        IError RemovePortType(string portTypeName)
        {

            if (portName.Contains(portTypeName))
            {
                portName.RemoveWhere(item => item == portTypeName);
                return Helpers.ErrorMessage(ErrorType.NoError);
            }
            else
            {
                return Helpers.ErrorMessage(ErrorType.NoItem,
                    "Nincs ilyen elem");
            }
        }
    }
}

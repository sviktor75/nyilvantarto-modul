﻿using BusinessLayer.Interfaces;
using Common;
using Common.Interfaces;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RegisterActive : IRegisterActive
    {
        private ILogService logService;

        private IList<IItemActive> itemList;

        public RegisterActive(ILogService logService)
        {
            this.logService = logService;
            itemList = new List<IItemActive>();
        }

        IItemActive IRegisterActive.this[int ID]
        {
            get
            {
                if (itemList.Count > 0)
                {
                    return itemList.Where(x => x.ID == ID).FirstOrDefault();
                }
                return null;
            }
        }

        IError IRegisterActive.Add(IItemActive item)
        {
            // TODO hibakezelés, ellenőrizni, megfelelő értékeket tartalmaz
            // a ItemActive
            itemList.Add(item);
            return Helpers.ErrorMessage(ErrorType.NoError);
        }

        IError IRegisterActive.Remove(IItemActive item)
        {
            // TODO: van e connection
            if (itemList.Remove(item))
            {
            return Helpers.ErrorMessage(ErrorType.NoError);
            }
            else
            {
            return Helpers.ErrorMessage(ErrorType.NoUniqueID,
                    "Nem létezik ilyen item");
            }
        }

        IError IRegisterActive.RemoveByID(int id)
        {
            // TODO: van e connection
            int index = GetIndex(id);
            if (index >= 0)
            {
                itemList.RemoveAt(index);
                return Helpers.ErrorMessage(ErrorType.NoError);
            }
            else
            {
                return Helpers.ErrorMessage(ErrorType.NoUniqueID,
                        "Nem létezik ilyen item");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;

namespace Common.Models
{
    public class LocationType
    {
        private HashSet<string> locationName = new HashSet<string>();

        public string this[string name]
        {
            get
            {
                return locationName.Where(item => item == name).FirstOrDefault();
            }
        }

        IError AddLocationType(string locationTypeName)
        {
            
            if (locationName.Contains(locationTypeName))
            {
                return Helpers.ErrorMessage(ErrorType.NoUniqueID,
                    "Ilyen típusú ingatlan/ helyiség létezik");
            }
            else
            {
                locationName.Add(locationTypeName);
                return Helpers.ErrorMessage(ErrorType.NoError);
            }
        }

        IError RemoveLocationType(string locationTypeName)
        {

            if (locationName.Contains(locationTypeName))
            {
                locationName.RemoveWhere(item => item == locationTypeName);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtFiletoUI
{
    internal class UserFormInfo
    {
        public string Name;
        public string Surname;
        public string YearofBirth;
        public string City;
        public string Faculty;
        public string Role;
        public string specificattribute;

        public UserFormInfo(string[] param)
        {
            Name = param[0];
            Surname = param[1];
            YearofBirth = param[2];
            City = param[3];
            Faculty = param[4];
            Role = param[5];
            specificattribute = "mystery";
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtFiletoUI
{
    internal class UserFormInfo
    {
        string Name;
        string Surname;
        string YearofBirth;
        string City;
        string Faculty;
        string Role;
        string specificattribute;

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

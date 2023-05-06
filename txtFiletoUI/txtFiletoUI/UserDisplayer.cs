using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtFiletoUI
{
    internal class UserDisplayer
    {   
        public void DisplayInfo(Form1 form, UserFormInfo current_UserForm)
        {
            if(current_UserForm != null && form!=null)
            {
                form.Controls["txtName"].Text = current_UserForm.Name;
                form.Controls["txtSurname"].Text = current_UserForm.Surname;
                form.Controls["txtYearOfBirth"].Text = current_UserForm.YearofBirth;
                form.Controls["txtCity"].Text = current_UserForm.City;
                form.Controls["txtFaculty"].Text = current_UserForm.Faculty;
                form.Controls["txtRole"].Text = current_UserForm.a_Role.Name;
                form.Controls["txtRoleDescription"].Text = current_UserForm.a_Role.Description;



            }
            else
            {

                Console.WriteLine("There is no form or place to display");
            }


        }
    }
}

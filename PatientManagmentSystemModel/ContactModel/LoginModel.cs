using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.ContactModel
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string User_Name { get; set; }
        public string User_Type { get; set; }
        public string Password { get; set; }
        public string Conform_Password { get; set; }

        public string Display { get { return string.Format("ID - {0} , User_Name - {1} ,User_Type - {2}, password - {3}", Id, User_Name,User_Type, Password); } }
    }
}

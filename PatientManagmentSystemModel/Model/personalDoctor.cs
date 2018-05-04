using PatientManagmentSystemModel.ContactModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.Model
{
    public class PersonalDoctor:PersonalModel
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.ContactModel
{
   public class IContactModel
    {
       

        public int Id { get; set; }
        public int bestContactTime { get; set; }
        public string PrefearedMethod { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Email { get; set; }
        public IContactModel() { }
        public IContactModel(string phoneNumber, string workNumber, string email)
        {
            PhoneNumber = phoneNumber;
            WorkNumber = workNumber;
            Email = email;
        }
        // void CreateContact(int id, string phoneNumber, string WorkNumber, string Email);
    }
}

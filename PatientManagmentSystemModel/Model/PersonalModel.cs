using PatientManagmentSystemModel.hospitalModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.Model
{
    public abstract class PersonalModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddelName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }


        public PersonalModel() { }
        public PersonalModel(string FirstName, String LastName) {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }
    }
}

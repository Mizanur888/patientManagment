using PatientManagmentSystemModel.ContactModel;
using PatientManagmentSystemModel.insurance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.Model
{
    public class RegesterPatient : PersonalModel
    {
        public IContactModel con { get; set; }
        public PersonalDoctor prcp { get; set; }
        public insuranceInfo infoins { get; set; }

        public List<IContactModel> contact { get; set; }
        public List<PersonalDoctor> pcp { get; set; }
        public List<insuranceInfo> ins { get; set; }

        public int Id { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int age { get; set; }
        public string MaritalStatus { get; set; }

        public int CalculateAge(DateTime dateofbirth)
        {
            return Age(DateOfBirth, DateTime.Now);
        }

        public int Age(DateTime dateTime, DateTime otherDate)
        {
            int result = 0;
            result = otherDate.Year - dateTime.Year;
            if (otherDate.DayOfYear < dateTime.DayOfYear)
            {
                result--;
            }
            return result;
        }


        public string Display{

            get { return string.Format("Name - {0}", FirstName + LastName); }
        }
    }
}

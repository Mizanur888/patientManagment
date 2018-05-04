using PatientManagmentSystemModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.hospitalModel
{
    public class doctor:PersonalModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
       // public string Speciality { get; set; }
        List<PatientModel> patients = new List<PatientModel>();
        List<nurse> nurses = new List<nurse>();
        
        public string display {
            get { return string.Format("{0}", Name); }
        }
        
    }
}

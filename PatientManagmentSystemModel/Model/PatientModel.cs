using PatientManagmentSystemModel.hospitalModel;
using PatientManagmentSystemModel.InterFaceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.Model
{
    public class PatientModel : PersonalModel
    {
        public int Id { get; set; }
        
        List<doctor> doctors = new List<doctor>();
        List<EmergencyContactModel> emergenctContacts = new List<EmergencyContactModel>();

    }
}

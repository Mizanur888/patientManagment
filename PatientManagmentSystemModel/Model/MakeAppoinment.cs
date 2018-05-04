using PatientManagmentSystemModel.hospitalModel;
using PatientManagmentSystemModel.insurance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.Model
{
    public class MakeAppoinment
    {
        public int Id { get; set; }
        public List<RegesterPatient> regpatient { get; set; }
        public regester regg { get; set; }
        public doctor doctors { get; set; } //= new List<doctor>();
        public insuranceInfo insCompany { get; set; }
        public string reasonforVisit { get; set; }
        public string AppoinmentArgency { get; set; }
        public string date { get; set; }
        public string time { get; set; }

        public string Display {
            get { return string.Format("ID{0} - regPatioId - {1} - doctor ID{2} - Reason for vist{3} - appoinment Argency - {4}" +
                "Date {5} - Time{6}", Id, regg.Id,doctors.Id,reasonforVisit,AppoinmentArgency,date,time); }
        }
    }
}

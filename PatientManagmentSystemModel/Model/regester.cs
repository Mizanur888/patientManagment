using PatientManagmentSystemModel.insurance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.Model
{
   public class regester
    {
        RegesterPatient pr = new RegesterPatient();
        insuranceInfo ins = new insuranceInfo();

        public int Id { get; set; }
        public List<RegesterPatient> regPatient { get; set; } = new List<RegesterPatient>();
        public List<insuranceInfo> infoPatient { get; set; } = new List<insuranceInfo>();


        public string display {

            get { return string.Format(Convert.ToString(Id), pr.FirstName ,pr.LastName, pr.Address, pr.City); }
        }
    }
}

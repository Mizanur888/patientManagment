using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.insurance
{
    public class insuranceInfo
    {
        public int Id { get; set; }
        public string InsuranceType { get; set; }
        public string insuranceCompany { get; set; }
        public string insureRelationShip { get; set; }
        public string programName { get; set; }
        public string iD_No { get; set; }
        public string GroupNo { get; set; }
        public string contactNo { get; set; }

        public insuranceInfo(){}
        //public List<insuranceInfo> ListOfInsurance = new List<insuranceInfo>();

       //public List<insuranceInfo> insList { get; set; }

    }
}

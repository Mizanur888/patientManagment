﻿using PatientManagmentSystemModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.hospitalModel
{
    public class nurse:PersonalModel
    {
        public int Id { get; set; }
        List<PatientModel> patients = new List<PatientModel>();
        List<doctor> doctors = new List<doctor>();

       
    }
}

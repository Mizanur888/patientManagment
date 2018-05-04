using PatientManagmentSystemModel.ContactModel;
using PatientManagmentSystemModel.hospitalModel;
using PatientManagmentSystemModel.insurance;
using PatientManagmentSystemModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientManagmentSystemModel.DbConnectin
{
    public interface IDBConnection
    {
        #region input data
        RegesterPatient regesterPatient(RegesterPatient model);
        IContactModel iContact(IContactModel model);
        PersonalDoctor pcpDoctor(PersonalDoctor model);
        insuranceInfo insurance(insuranceInfo patientIns);
        regester patients(regester patient);
        MakeAppoinment appoinments(MakeAppoinment appoinment);
        LoginModel insertMember(LoginModel model);
        #endregion

        #region out put data

        List<regester> GetAll();
        List<doctor> GetAllDoctor();
        List<MakeAppoinment> GetAllAppoinment();
        List<LoginModel> GetAllUser();
        #endregion'

        #region update Data
        insuranceInfo ins(insuranceInfo update);


        #endregion
    }
}

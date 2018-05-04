using System;
using System.Collections.Generic;
using System.Text;
using PatientManagmentSystemModel.ContactModel;
using PatientManagmentSystemModel.hospitalModel;
using PatientManagmentSystemModel.insurance;
using PatientManagmentSystemModel.Model;

namespace PatientManagmentSystemModel.DbConnectin
{
    public class TextConnector : IDBConnection
    {
        public MakeAppoinment appoinments(MakeAppoinment appoinment)
        {
            throw new NotImplementedException();
        }

        public List<MakeAppoinment> GetAllAppoinment()
        {
            throw new NotImplementedException();
        }

        public List<doctor> GetAllDoctor()
        {
            throw new NotImplementedException();
        }

        public List<LoginModel> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public RegesterPatient iContact(IContactModel model)
        {
            throw new NotImplementedException();
        }

        public RegesterPatient iContact(RegesterPatient model)
        {
            throw new NotImplementedException();
        }

        public insuranceInfo ins(insuranceInfo update)
        {
            throw new NotImplementedException();
        }

        public LoginModel insertMember(LoginModel model)
        {
            throw new NotImplementedException();
        }

        public insuranceInfo insurance(insuranceInfo patientIns)
        {
            throw new NotImplementedException();
        }

        public regester patients(regester patient)
        {
            throw new NotImplementedException();
        }

        public PersonalDoctor pcpDoctor(RegesterPatient model)
        {
            throw new NotImplementedException();
        }

        public PersonalDoctor pcpDoctor(PersonalDoctor model)
        {
            throw new NotImplementedException();
        }

        public IContactModel regesterPatient(IContactModel model)
        {
            throw new NotImplementedException();
        }

        public RegesterPatient regesterPatient(RegesterPatient model)
        {
            throw new NotImplementedException();
        }

        List<regester> IDBConnection.GetAll()
        {
            throw new NotImplementedException();
        }

        IContactModel IDBConnection.iContact(IContactModel model)
        {
            throw new NotImplementedException();
        }

        insuranceInfo IDBConnection.insurance(insuranceInfo patientIns)
        {
            throw new NotImplementedException();
        }

        regester IDBConnection.patients(regester patient)
        {
            throw new NotImplementedException();
        }

        PersonalDoctor IDBConnection.pcpDoctor(PersonalDoctor model)
        {
            throw new NotImplementedException();
        }

        RegesterPatient IDBConnection.regesterPatient(RegesterPatient model)
        {
            throw new NotImplementedException();
        }
    }
}

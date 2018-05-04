using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using PatientManagmentSystemModel.Model;
using Dapper;
using PatientManagmentSystemModel.ContactModel;
using PatientManagmentSystemModel.insurance;
using System.Linq;
using PatientManagmentSystemModel.hospitalModel;

namespace PatientManagmentSystemModel.DbConnectin
{
    class SQLConnector : IDBConnection
    {
        private const string db = "PatientManagment";

        public RegesterPatient regesterPatient(RegesterPatient model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db))) {
                var pr = new DynamicParameters();
                pr.Add("@FirstName", model.FirstName);
                pr.Add("@MiddelName", model.MiddelName);
                pr.Add("@LastName", model.LastName);
                pr.Add("@Address", model.Address);
                pr.Add("@City", model.City);
                pr.Add("@State", model.State);
                pr.Add("@Zip", model.Zip);
                pr.Add("@DateOfBirth", model.DateOfBirth);
                pr.Add("@age", model.age);
                pr.Add("@Gender", model.Gender);
                pr.Add("@MaritalStatus", model.MaritalStatus);

                foreach (IContactModel info in model.contact)
                {
                    pr.Add("@contactInfo_ID", info.Id);
                }
                foreach (PersonalDoctor info in model.pcp)
                {
                    pr.Add("@personalDoctor_Id", info.Id);
                }
                
                pr.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spRegesterPatientDataInsert", pr, commandType: CommandType.StoredProcedure);
                model.Id = pr.Get<int>("@Id");
                return model;
            }

        }
        public MakeAppoinment appoinments(MakeAppoinment appoinment) {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db))) {
                var app = new DynamicParameters();

                
                app.Add("@regpatient_ID",appoinment.regg.Id);
                app.Add("@doctor_Id", appoinment.doctors.Id);
                app.Add("@reasonForVisit", appoinment.reasonforVisit);
                app.Add("@appoinmentArgency", appoinment.AppoinmentArgency);
                app.Add("@date",appoinment.date);
                app.Add("@time", appoinment.time);
                app.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("[dbo].[spAppoinmentInsert]",app,commandType:CommandType.StoredProcedure);
                appoinment.Id = app.Get<int>("@Id");
            }
                return appoinment;
        }


        private void save_insurance(IDbConnection connection, insuranceInfo patientIns) {
            var ins = new DynamicParameters();
            ins.Add("@InsuranceType", patientIns.InsuranceType);
            ins.Add("@insuranceCompany", patientIns.insuranceCompany);
            ins.Add("@insureRelationShip", patientIns.insureRelationShip);
            ins.Add("@programName", patientIns.programName);
            ins.Add("@ID_No", patientIns.iD_No);
            ins.Add("@GroupNo", patientIns.GroupNo);
            ins.Add("@contactNo", patientIns.contactNo);
            ins.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("dbo.spInsuranceInsert", ins, commandType: CommandType.StoredProcedure);
            patientIns.Id = ins.Get<int>("@Id");
            //return patientIns;
        }
        private void save_pcpDoctor(IDbConnection connection, PersonalDoctor dr) {

            var pr = new DynamicParameters();
            pr.Add("@FirstName", dr.FirstName);
            pr.Add("@LastName", dr.LastName);
            pr.Add("@PhoneNumber", dr.PhoneNumber);
            pr.Add("@Email", dr.Email);
            pr.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("[dbo].spPersonalDoctor", pr, commandType: CommandType.StoredProcedure);
            dr.Id = pr.Get<int>("@Id");
        }
        private void Save_Contact(IDbConnection connection, IContactModel model) {
            var pr = new DynamicParameters();
            pr.Add("@BestContactTime", model.bestContactTime);
            pr.Add("@PrefeardMethod", model.PrefearedMethod);
            pr.Add("@PhoneNumber", model.PhoneNumber);
            pr.Add("@WorkNumber", model.WorkNumber);
            pr.Add("@Email", model.Email);
            pr.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("dbo.spInsetContactInforNew", pr, commandType: CommandType.StoredProcedure);
            model.Id = pr.Get<int>("@Id");
        }
        
        public insuranceInfo insurance(insuranceInfo patientIns)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db)))
            {
                var ins = new DynamicParameters();
                ins.Add("@InsuranceType", patientIns.InsuranceType);
                ins.Add("@insuranceCompany", patientIns.insuranceCompany);
                ins.Add("@insureRelationShip", patientIns.insureRelationShip);
                ins.Add("@programName", patientIns.programName);
                ins.Add("@ID_No", patientIns.iD_No);
                ins.Add("@GroupNo", patientIns.GroupNo);
                ins.Add("@contactNo", patientIns.contactNo);
                ins.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spInsuranceInsert", ins,commandType:CommandType.StoredProcedure);
                patientIns.Id = ins.Get<int>("@Id");
                return patientIns;
            }
        }

        public PersonalDoctor pcpDoctor(PersonalDoctor dr)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db)))
            {
                
                var pr = new DynamicParameters();
                pr.Add("@FirstName", dr.FirstName);
                pr.Add("@LastName", dr.LastName);
                pr.Add("@PhoneNumber", dr.PhoneNumber);
                pr.Add("@Email", dr.Email);
                pr.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("[dbo].spPersonalDoctor", pr, commandType: CommandType.StoredProcedure);
                dr.Id = pr.Get<int>("@Id");
                return dr;
            }
        }

        public IContactModel iContact(IContactModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db)))
            {
                var pr = new DynamicParameters();
                pr.Add("@BestContactTime", model.bestContactTime);
                pr.Add("@PrefeardMethod", model.PrefearedMethod);
                pr.Add("@PhoneNumber", model.PhoneNumber);
                pr.Add("@WorkNumber", model.WorkNumber);
                pr.Add("@Email", model.Email);
                pr.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spInsetContactInforNew", pr, commandType: CommandType.StoredProcedure);
                model.Id = pr.Get<int>("@Id");
                return model;
            }
            
        }

        public regester patients(regester patient)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db)))
            {
                var reg = new DynamicParameters();

                foreach (RegesterPatient rog in patient.regPatient)
                {
                    reg.Add("@regester_patient_Id", rog.Id);
                }

                foreach (insuranceInfo info in patient.infoPatient) {
                    reg.Add("@insurance_Id", info.Id);
                }

                reg.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPatientRegesterID_Table", reg, commandType: CommandType.StoredProcedure);
                patient.Id = reg.Get<int>("@Id");
            }
            return patient;
        }

        public List<regester> GetAll()
        {
            List<regester> output = new List<regester>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db))) {
                //output = connection.Query<TeamModel>("Tournament.dbo.spPeople_GetAll").ToList();
                output = connection.Query<regester>("[dbo].[spGetPatientGata]").ToList();
            }
            
            return output;
        }

        public List<doctor> GetAllDoctor()
        {
            List<doctor> outpot = new List<doctor>();
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db)))
            {
                outpot = conn.Query<doctor>("dbo.spGetAll_Doctor").ToList();    
            }
            return outpot;
        }

        public List<MakeAppoinment> GetAllAppoinment()
        {
            List<MakeAppoinment> output;
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db))) {

                output = conn.Query<MakeAppoinment>(" dbo.spGetAppoinmentData").ToList();
            }
            return output;
        }

        public List<LoginModel> GetAllUser()
        {
            List<LoginModel> model = new List<LoginModel>();

            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db)))
            {

                model = conn.Query<LoginModel>("[dbo].[spGetAllUser]").ToList();                    //("select * from [dbo].[Login_System] where User_Type = '" + userNameText.Text + "' and password = '" + passwordText.Text + "'").ToList();

            }
            return model;
        }

        public LoginModel insertMember(LoginModel model)
        {
           // LoginModel mg = new LoginModel();
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db))) {
                var lg = new DynamicParameters();
                lg.Add("@User_Name", model.User_Name);
                lg.Add("@User_Type", model.User_Type);
                lg.Add("@Password", model.Password);
                lg.Add("@Conform_Password", model.Conform_Password);
                lg.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                conn.Execute("dbo.spMemberInsert",lg,commandType:CommandType.StoredProcedure);
                model.Id = lg.Get<int>("@Id");
            }
            return model;
        }
        //TODO update data
        public insuranceInfo ins(insuranceInfo update)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.connString(db))) {

              //  string sql = "update [dbo].[insurance] set InsuranceType = '', insuranceCompany = '', insureRelationShip = '', programName = '', ID_No = '', GroupNo = '', contactNo = ''where Id = '3'"
            }
                throw new NotImplementedException();
        }
    }
}

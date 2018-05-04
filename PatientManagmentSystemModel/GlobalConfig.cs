using PatientManagmentSystemModel.DbConnectin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PatientManagmentSystemModel
{
    public class GlobalConfig: Form
    {
        public static IDBConnection connection { get; private set; }

        public static void initConnection(dataType db) {

            if (db == dataType.SQL)
            {

                SQLConnector sql = new SQLConnector();
                connection = sql;
            }

            else if (db == dataType.TEXT) {

                TextConnector text = new TextConnector();
                connection = text;
                
            }
        }

        public static string connString(string name) {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString; 
        }
        //validate text
        public static Regex nameValidation = new Regex(@"^[A-Za-z]+$");
        public static Regex phoneValidation = new Regex(@"^[0-9]+$");
        public static bool exp(string text, Regex pattern)
        {
           
                if (pattern.IsMatch(text.ToString()))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalied Digit Entered.  Please Avoid Enter unwanted Digit");
                    return false;
                   
                }
            
        }
        //validate Email
        public static bool EmialValidation(string emailaddress)
        {
            try
            {
                if (emailaddress.Length > 0)
                {
                    MailAddress m = new MailAddress(emailaddress);
                    return true;
                }
                else {
                    MessageBox.Show("Invalied Email");
                    return false;
                }
                
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace The_Automated_Super_Mail
{
    internal class SQLController
    {
        private static string conString = "User Id = s81969;Password=s81969;Data Source =(DESCRIPTION =  (ADDRESS = (PROTOCOL = tcp)(HOST = 217.173.198.135)(PORT = 1521)) (CONNECT_DATA = (SERVICE_NAME = tpdb)));";

        public static DataTable GetManagerEmails()
        {
            try
            {
                using (var connection = new OracleConnection(conString))
                {
                    connection.Open();
                    OracleCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT EMAIL_ADDRESS FROM MANAGERS";
                    cmd.CommandType = System.Data.CommandType.Text;
                    var dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    connection.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

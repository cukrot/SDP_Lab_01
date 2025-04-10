using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessController
{
    public class dboUserLogin : dboDatabaseController
    {
        public dboUserLogin(string connectionString) : base(connectionString)
        {
        }
        public bool User(string username, string password)
        {
            String sqlCmd = "SELECT * FROM Users WHERE Username = '" + username + "' and Password = '" + password + "'";
            DataTable dt = GetData(sqlCmd); 
            return dt.Rows.Count > 0;
        }
        public int RegisterUser(string username, string password)
        {
            String sqlCmd = $"INSERT INTO `user` (`username`, `password`) VALUES ('{username}', '{password}')";
            return BatchUpdate(sqlCmd);
        }
    }
}

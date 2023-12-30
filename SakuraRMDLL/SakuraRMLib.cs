
using System.Data;
using MySql.Data.MySqlClient;
using SakuraRMDLL.Models;

namespace SakuraRMDLL
{
    public class SakuraRMLib
    {
        internal IDbConnection Connection;

        public SakuraRMLib(IDbConnection _con) 
        {
            Connection = _con;
            // 接続する
            Connection.Open();
        }

        public SakuraRMLib(string _server, string _id, string _pw, uint _port = 3306) 
        {
            Connection = new MySqlConnection(
                new MySqlConnectionStringBuilder
                {
                    Server = _server,
                    Port = _port,
                    UserID = _id,
                    Password = _pw,
                    Database = "tvinfo"
                }.ToString()
                );
            // 接続する
            Connection.Open();
        }

        public class Channel 
        {
            public void Channel()
            {
                SakuraRMLib.Connection
            }
        };
    }
}

using System.Data;
using Dapper;
using SakuraRMDLL;

namespace SakuraRMDLL.Models
{
    partial class Channels
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Channels(string _name)
        {
            SakuraRMLib.Connection.QueryFirstOrDefault<Channels>();
        }

        // DBから取得

        public static Channels SingleSelect()
        {
            try
            {
                SakuraRMLib.Connection.QueryFirstOrDefault<Channels>(
                    $"SELECT * FROM channels WHERE ")
            }
        }
}

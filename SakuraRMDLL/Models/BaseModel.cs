using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SakuraRMDLL.Common;
using Dapper;

namespace SakuraRMDLL.Models
{
    internal class BaseModel
    {
        private protected BaseModel() { }

        private protected BaseModel(IDbConnection _con)
        {
            if (!CheckConnection(_con)) throw new SakuraRMDllException("DBに接続できないかコネクションが閉じています");
        }

        // Insert
        public void Insert(IDbConnection _con)
        {
            try
            {
                // トランザクション処理
                var transaction = _con.BeginTransaction();
                _con.Execute
            }
        }

        private protected bool CheckConnection(IDbConnection _con)
        {
            try { return _con.State.Equals(ConnectionState.Open) ? true : false; }
            catch (Exception) { return false; }
        }

    }
}

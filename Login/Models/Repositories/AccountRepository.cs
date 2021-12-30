using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Login.Models.DomainModels;
using Dapper;
using System.Data.SqlClient;

namespace Login.Models.Repositories
{
    public interface IAccountRepository
    {
        void Login(Account model);

    }



    public class AccountRepository : IAccountRepository
    {
        private readonly string connStr;
        private const string tableName = "account";

        public AccountRepository(string connStr)
        {
            this.connStr = connStr;
        }


        public void Login(Account model)
        {
            using (var conn = new SqlConnection(this.connStr))
            {
                string sql = $"select * from {tableName}where account = {model.account}, password={model.password}";
                conn.Execute(sql,model);
            }
        }
    }
}
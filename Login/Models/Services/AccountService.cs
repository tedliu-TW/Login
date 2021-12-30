using Login.Models.DomainModels;
using Login.Models.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models.Services
{
    public class AccountService
    {
        private readonly IAccountRepository repo;
        Account model = new Account();
        public AccountService(IAccountRepository repo)
        {
            this.repo = repo;
        }

        public void Login(string account,string password)
        {
              if(account!=model.account) throw new Exception("帳號錯誤");
              if(password!= model.password) throw new Exception("密碼錯誤");

              this.repo.Login(model);
        }

    }
}
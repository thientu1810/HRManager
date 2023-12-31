﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        public AccountDAO accountDAO;
        public AccountBUS()
        {
            accountDAO = new AccountDAO();
        }
        public List<Account> getAll()
        {
            return accountDAO.GetAll();
        }
        public string Add(Account account)
        {
            if(accountDAO.Add(account))
            {
                return "Add Success";
            }
            else
            {
                return "Add Fail";
            }
        }
        public int GetIdByUsername(string  username)
        {
            return accountDAO.GetIdByUsername(username);
        }
        public Account GetById(int id)
        {
            return accountDAO.GetById(id);
        }
        public List<Account> GetUserName(string s)
        {
            return accountDAO.GetUserName(s);
        }
        public void UpdatePassword(string username, string password)
        {
            accountDAO.UpdatePassword(username, password);
        }
    }
}

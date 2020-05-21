using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class UserManager : IUserManager
    {
        public IUserDB UserDB { get; }

        public UserManager(IUserDB userDB)
        {
            UserDB = userDB;
        }

        public List<UserAccount> GetUsers()
        {
            return UserDB.GetUsers();
        }

        public float GetAvailableAmount(int id)
        {
            return UserDB.GetAvailableAmount(id);
        }

        public int ReloadMoneyUID(int id, double amount)
        {
            return UserDB.ReloadMoneyUID(id, amount);
        }


    }
}

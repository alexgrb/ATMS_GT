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

        public int GetAvailableAmount(int id)
        {
            return UserDB.GetAvailableAmount(id);
        }

        public int ReloadMoneyUID(int id, int amount)
        {
            int availableAmount = UserDB.GetAvailableAmount(id);

            amount += availableAmount;
            return UserDB.ReloadMoneyUID(id, amount);
        }

        public string getUsernameByCardID(int cardID)
        {
            return UserDB.getUsernameByCardID(cardID);
        }


    }
}

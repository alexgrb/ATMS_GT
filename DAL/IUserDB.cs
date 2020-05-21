using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IUserDB
    {
        List<UserAccount> GetUsers();
        float GetAvailableAmount(int id);
        int ReloadMoneyUID(int id, double amount);
    }
}

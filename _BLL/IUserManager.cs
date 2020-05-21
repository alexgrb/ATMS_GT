
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IUserManager
    {
        List<UserAccount> GetUsers();
        float GetAvailableAmount(int id);
        int ReloadMoneyUID(int id, double amount);
        
    }
}

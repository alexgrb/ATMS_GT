﻿using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IUserDB
    {
        List<UserAccount> GetUsers();
        int GetAvailableAmount(int id);
        int ReloadMoneyUID(int id, int amount);

        string getUsernameByCardID(string cardID);

        int ReloadMoneyUsername(string username, int amount);
        int GetAvailableAmountByUsername(string username);
    }
}

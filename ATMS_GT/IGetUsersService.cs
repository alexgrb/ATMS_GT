﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;



namespace ATMS_GT
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IGetUsersService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IGetUsersService
    {
        [OperationContract]
        List<UserAccount> GetUsers();

        [OperationContract]
        int GetAvailableAmount(int uid);
        [OperationContract]
        void ReloadMoneyUID(int uid, int amount);

        [OperationContract]
        string getUsernameByCardID(string cardID);

        [OperationContract]
        void ReloadMoneyUsername(string username, int amount);

    }
}



using BLL;
using DAL;
using DTO;
using System.Collections.Generic;

namespace ATMS_GT
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "GetUsersService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez GetUsersService.svc ou GetUsersService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class GetUsersService : IGetUsersService
    {
        public List<UserAccount> GetUsers()
         {
            IUserDB userDB = new UsersDB();
            IUserManager usersManager = new UserManager(userDB);
            List<UserAccount> listUsers = usersManager.GetUsers();
            return listUsers;
        }
        public int GetAvailableAmount(int uid)
        {
            IUserDB userDB = new UsersDB();
            IUserManager usersManager = new UserManager(userDB);
            int availableAmount = usersManager.GetAvailableAmount(uid);
            return availableAmount;
        }

        public void ReloadMoneyUID(int uid, int amount)
        {
            IUserDB userDB = new UsersDB();
            IUserManager usersManager = new UserManager(userDB);
            usersManager.ReloadMoneyUID(uid, amount); 
        }

    }
}

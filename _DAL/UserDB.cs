using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class UsersDB : IUserDB
    {

        public string connectionString = null;

        public UsersDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["WebServiceDB"].ConnectionString;
        }

        public List<UserAccount> GetUsers()
        {
            List<UserAccount> results = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [UserAccount] ORDER BY Username";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (results == null)
                                results = new List<UserAccount>();

                            UserAccount user = new UserAccount();
                            user.UID = (int)dr["UID"];
                            user.Username = (string)dr["Username"];
                            user.CardID = (string)dr["CardID"];
                            user.AmountAvailable = (float)dr["AmountAvailable"];
                            
                            results.Add(user);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return results;
        }

        public float GetAvailableAmount(int uid)
        {
            float amount = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT AmountAvailable FROM [UserAccount] where UID = @uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@uid", uid);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        amount = (float)dr["AmountAvailable"];
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return amount;
        }

        public int ReloadMoneyUID(int uid, double amount)
        {
            int result = 0;
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE [UserAccount] SET AmountAvailable=@amount WHERE UID=@uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@uid", uid);
                    cmd.Parameters.AddWithValue("@amount", amount);

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}

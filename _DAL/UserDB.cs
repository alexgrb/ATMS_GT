﻿using System;
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
            //hello
            connectionString = ConfigurationManager.ConnectionStrings["DatabaseDB"].ConnectionString;
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
                            user.AmountAvailable = (int)dr["AmountAvailable"];
                            
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

        public int GetAvailableAmount(int uid)
        {
            int amount = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT AmountAvailable FROM [UserAccount] WHERE UID = @uid";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@uid", uid);

                    cn.Open();
                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            amount = (int)dr["AmountAvailable"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return amount;
        }

        public int GetAvailableAmountByUsername(string username)
        {
            int amount = 0;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT AmountAvailable FROM [UserAccount] WHERE Username = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            amount = (int)dr["AmountAvailable"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return amount;
        }

        public string getUsernameByCardID(string cardID)
        {
            string username = "";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Username FROM [UserAccount] WHERE CardID = @cardID";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@cardID", cardID);

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            username = (string)dr["Username"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return username;
        }

        public int ReloadMoneyUID(int uid, int amount)
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

        public int ReloadMoneyUsername(string username, int amount)
        {
            int result = 0;
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE [UserAccount] SET AmountAvailable=@amount WHERE Username =@username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);
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

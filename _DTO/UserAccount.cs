using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UserAccount
    {
        
        public int UID { get; set; }
        public string Username { get; set; }
        public string CardID { get; set; }
        public int AmountAvailable { get; set; }

        public override string ToString()
        {
            return $"{Username}|{CardID}|{AmountAvailable}";
        }
    }
}

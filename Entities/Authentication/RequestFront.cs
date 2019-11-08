using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSPortal.Models;

namespace NSPortal.Entities.Authentication

{
    public class RequestFront
    {
        //public Account Account;
        //public User User;
        public string email { get; set; }
        public string password { get; set; }
        public string nickname { get; set; }

        public RequestFront(string email, string password, string nickname)
        {
            this.email = email;
            this.password = password;
            this.nickname = nickname;
        }
    }
}

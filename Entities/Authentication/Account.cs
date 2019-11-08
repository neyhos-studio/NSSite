using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSPortal.Models
{
    public class Account
    {
        public string registerEmail { get; set; }
        public string registerPassword { get; set; }

        public Account(string registerEmail, string registerPassword)
        {
            this.registerEmail = registerEmail;
            this.registerPassword = registerPassword;
        }
    }
}

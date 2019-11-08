using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSPortal.Entities.Authentication
{
    public class User
    {
<<<<<<< HEAD
        public string registerNickname { get; set; }
        public string firstNameUser { get; set; }
        public string lastNameUser { get; set; }
        public DateTime birthdayUser { get; set; }
        public string genderUser { get; set; }
        public User(string registerNickname)
=======
        public string nickNameUser { get; set; }

        public User(string nickName)
>>>>>>> 4ad74926a96c949b0f0c325b5f22580c00a36b2e
        {
            this.registerNickname = registerNickname;
        }
    }
}

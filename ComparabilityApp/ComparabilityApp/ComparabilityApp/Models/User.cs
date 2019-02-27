using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparabilityApp.Models
{
    class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;

        }


        public bool CheckInformation()
        {
            if (!this.Email.Equals("") && !this.Password.Equals(""))
            {
                return true;
            }
            else
                return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_game
{
    public class Account
    {
        readonly int id;
        string nick;
        string email;
        string password;

        Account()
        {
            id = 0;
            this.nick = Nick;
            this.email = Email;
            this.password = Password;
        }

        public int Id { get { return id; } }
        public string Nick { get { return nick; } set { nick = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
    }
}

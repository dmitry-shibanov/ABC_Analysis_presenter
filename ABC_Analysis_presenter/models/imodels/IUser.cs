using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Analysis_presenter
{
    public abstract class IUser
    {
        private string password;
        private string login;
        private string position;

        public string Position { get { return position; } }
        public string Login { get { return login; } }
        public string Password { get { return password; } }

        public IUser(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public abstract bool logout();
    }
}

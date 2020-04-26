using ABC_Analysis_presenter.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Analysis_presenter.bll
{
    class SystemUser
    {
        private static IUser User;
        public static bool isAnalitic { get; private set; }
        public delegate void updatePermissions(string str);
        public updatePermissions permissions { get; set; }

        private SystemUser()
        {

        }

        public static IUser getCurrentUser()
        {
            if(User == null)
            {
                throw new NoAuthorizedException();
            }

            return User;
        }

        public static IUser login(IUser user)
        {

            return User;
        }
    }
}

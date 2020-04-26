using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Analysis_presenter.models
{
    public class NoAuthorizedException : Exception
    {
        public NoAuthorizedException() : this("Такого пользователя нет в системе") { }

        public NoAuthorizedException(string message) : base(message) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Analysis_presenter.database
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<IUser> Users { get; }
        void Save();
    }
}

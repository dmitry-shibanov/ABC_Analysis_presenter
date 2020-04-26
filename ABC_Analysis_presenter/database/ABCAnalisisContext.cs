using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Analysis_presenter.database
{

    public class ABCAnalisisContext : DbContext
    {
        public DbSet<IUser> Users { get; set; }

        public ABCAnalisisContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}

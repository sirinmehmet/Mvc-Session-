using InternetBankaciligi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBankaciligi.DataAccess.Contexts
{
    public class InternetBankaciligiDbContext : DbContext
    {
        public InternetBankaciligiDbContext() : base("InternetBankaciligiDbContext")
        {

        }

        public DbSet<User> User { get; set; }
    }
}

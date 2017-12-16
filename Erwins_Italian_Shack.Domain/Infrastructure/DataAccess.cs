using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erwins_Italian_Shack.Domain.Infrastructure
{
    public class DataAccess : DbContext
    { 
        public DataAccess() : base("myConnectionString")
        {
            Database.SetInitializer(
                new Erwins_Italian_Shack.Domain.Infrastructure.DataInitializer()
                );
        }
        public DbSet<Models.User> Users { get; set; }
    }
}

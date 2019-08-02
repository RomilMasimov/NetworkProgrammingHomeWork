using LostServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostServer.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Poteryashka> Poteryashkas { get; set; }
        public DbSet<Seen> Seens { get; set; }

        public ApplicationContext(string connectionStr) : base(connectionStr)
        {
            Database.SetInitializer(new PoteryashkasDbContextInitializer());
        }
    }
}

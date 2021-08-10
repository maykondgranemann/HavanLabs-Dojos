using Dojo11.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo11.Context
{
    class BaseContext : DbContext
    {
        public DbSet<Drogas> Drogas { get; set; }
        public DbSet<Farmacia> Farmacia { get; set; }
        public BaseContext():base("DrogasConnection")
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEF
{
    public class NihatContext:DbContext
    {
        public DbSet<NihatProduct> nihatProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-DPEUUKQ\\SQLEXPRESS;Database=learningEf;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}

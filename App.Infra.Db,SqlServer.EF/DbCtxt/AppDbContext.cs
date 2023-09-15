using App.Domain.core.Student.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db_SqlServer.EF.DbCtxt
{
    internal class AppDbContext :DbContext
    {
        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Architecte;integrated security=sspi;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }
    }
}

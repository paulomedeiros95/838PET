using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _838PET.Models;
using Microsoft.EntityFrameworkCore;

namespace _838PET.Areas.Application.Data 
{
    public class ApplicationDBContext : DbContext
    {
        #region Public Properties DbSet

        public DbSet<PetServicos> PetServicos { get; set; }
        public DbSet<PetProduct> Produtos { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=838PET_DEV;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            

        }
    }
}

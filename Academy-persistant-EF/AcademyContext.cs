using System;
using System.Collections.Generic;
using System.Text;
using Academy_Domain;
using Academy_persistant_EF.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Academy_persistant_EF
{
  public  class AcademyContext:DbContext
    {
        public  DbSet<CourseCategory> CourseCategories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "data source=.;initial catalog=practicedatabase;user ID=sa;password=johankerayof");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseCategoryMappings());
            base.OnModelCreating(modelBuilder);
        }
    }
}

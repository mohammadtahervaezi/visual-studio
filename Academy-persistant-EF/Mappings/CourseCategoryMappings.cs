using System;
using System.Collections.Generic;
using System.Text;
using Academy_Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy_persistant_EF.Mappings
{
    class CourseCategoryMappings:IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.ToTable("CourseCategories").HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.HasMany(x => x.Children).WithOne(x => x.Parent).HasForeignKey(x => x.parentId);
        }
        
    }
}

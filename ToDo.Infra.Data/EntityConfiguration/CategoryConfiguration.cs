using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Infra.Data.EntityConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(250);

            builder.HasData(
                new Category { Title = "Dever de casa"},
                new Category { Title = "Estudar JAVA", Description = "Focar no estudo de Spring"},
                new Category { Title = "Lavar a louça", Description = "Ariar as panelas"}
            );
        }
    }
}

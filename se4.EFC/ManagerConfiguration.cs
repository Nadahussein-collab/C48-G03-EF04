using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace se4.EFC
{
    internal class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.FullName).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Email).IsRequired().HasMaxLength(150);
            builder.Property(m => m.PhoneNumber).HasMaxLength(20);

            builder.HasData(
                new Manager { Id = 1, FullName = "Hassan Ali", Email = "hassan.manager@bank.com", PhoneNumber = "01001234567", HireDate = new DateTime(2018, 5, 1) },
                new Manager { Id = 2, FullName = "Mona Zaki", Email = "mona.manager@bank.com", PhoneNumber = "01123456789", HireDate = new DateTime(2020, 3, 15) }
            );
        }
    }
}

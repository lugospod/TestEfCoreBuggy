using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;
using TestEfCoreBuggy.Model;

namespace TestEfCoreBuggy
{
    public class MyTypeConfiguration : IEntityTypeConfiguration<MyEntity>
    {
        public void Configure(EntityTypeBuilder<MyEntity> builder)
        {
            var ownershipFirst = builder.OwnsOne(p => p.FirstOE)
           .OnDelete(DeleteBehavior.Restrict);
            ownershipFirst.Property(c => c.CodebookId).HasColumnName("first_codebook_id"); ;
            ownershipFirst.Property(c => c.Name).HasColumnName("first_codebook_name"); ;


            var ownershipSecond = builder.OwnsOne(p => p.SecondOE)
              .OnDelete(DeleteBehavior.Restrict);
            ownershipSecond.Property(c => c.CodebookId).HasColumnName("second_codebook_id"); ;
            ownershipSecond.Property(c => c.Name).HasColumnName("second_codebook_name"); ;

            builder.HasData(new MyEntity() { Id = 1 });

            ownershipFirst.HasData(new { MyEntityId = 1, CodebookId = 1, Name = "Test" });
            ownershipSecond.HasData(new { MyEntityId = 1, CodebookId = 2, Name = "Test2" });
        }
    }
}
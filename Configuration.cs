using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;
using TestEfCoreBuggy.Model;

namespace TestEfCoreBuggy
{
    public class PartEntityConfiguration : IEntityTypeConfiguration<PartEntity>
    {
        public void Configure(EntityTypeBuilder<PartEntity> builder)
        {
            builder.HasData(
                new PartEntity() { Id = 1, TemplateId = 1, Text = "Part1" },
                new PartEntity() { Id = 2, TemplateId = null, Text = "Part2" });
            //builder
            //.HasOne(x => x.Template)
            //.WithMany(x => x.Parts)
            //.HasForeignKey(x => x.TemplateId)
            //.IsRequired(false);
        }
    }

    public class TemplateEntityConfiguration : IEntityTypeConfiguration<TemplateEntity>
    {
        public void Configure(EntityTypeBuilder<TemplateEntity> builder)
        {
            builder.HasData(
                new TemplateEntity() { Id = 1, Text = "Template1" });


        }
    }
}
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
            //builder
            //.HasOne(x => x.Te)
            //.WithMany(x => x.Parts)
            //.HasForeignKey(x => x.TemplateId)
            //.IsRequired(false);
        }
    }

    public class TemplateEntityConfiguration : IEntityTypeConfiguration<TemplateEntity>
    {
        public void Configure(EntityTypeBuilder<TemplateEntity> builder)
        {
        }
    }
}
using DataModel.Entities;
using DataModel.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{


    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void  Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.ToTable("Category");
            builder.Property(e => e.Id).HasColumnName("CategoryId");
            builder.HasKey(x => x.Id).HasName("PK_CategoryId");

            builder.Property(e => e.Description).HasMaxLength(maxLength: int.MaxValue);



        }
    }
}

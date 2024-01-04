using DataModel.Entities;
using DataModel.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{


    public class BookConfiguration : BaseConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);

            builder.ToTable("Book");
            builder.Property(e => e.Id).HasColumnName("BookId");
            builder.HasKey(x => x.Id).HasName("PK_BookId");

            builder.Property(e => e.Description).HasMaxLength(maxLength: int.MaxValue);



        }
    }
}

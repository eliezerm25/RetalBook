using DataModel.Entities;
using DataModel.EntityConfigurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.EntityConfigurations
{


    public class AuthorConfiguration : BaseConfiguration<Author>
    {
        public override void Configure(EntityTypeBuilder<Author> builder)
        {
            base.Configure(builder);
            builder.ToTable("Author");
            builder.Property(e => e.Id).HasColumnName("AuthorId");
            builder.HasKey(x => x.Id).HasName("PK_AuthorId");

            builder.Property(e => e.Name).HasMaxLength(maxLength:100);
            builder.Property(e => e.LastName).HasMaxLength(maxLength:200);



        }
    }
}

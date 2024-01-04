using DataModel.Entities;
using DataModel.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.EntityConfigurations.Base
{
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {

            builder.HasQueryFilter(e => !e.Deleted);
            builder.Property(e => e.DateCreated).HasDefaultValueSql("Getdate()");
            builder.Property(e => e.ByDeleted).HasMaxLength(maxLength: 50);
            builder.Property(e => e.ByCreated).HasMaxLength(maxLength: 50);
            builder.Property(e => e.ByModified).HasMaxLength(50);


        }

    }
}

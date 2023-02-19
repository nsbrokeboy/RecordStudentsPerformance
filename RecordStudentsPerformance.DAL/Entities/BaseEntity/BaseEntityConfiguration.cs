﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecordStudentsPerformance.DAL.Entities.BaseEntity
{
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v1mc()");
            builder.Property(x => x.CreatedOn).HasDefaultValueSql("NOW()");
            builder.Property(x => x.ModifiedOn).HasDefaultValueSql("NOW()");
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
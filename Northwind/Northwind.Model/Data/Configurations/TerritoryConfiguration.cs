// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Northwind.Model.Data;
using Northwind.Model.Models;
using System;


namespace Northwind.Model.Data.Configurations
{
    public partial class TerritoryConfiguration : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> entity)
        {
            entity.HasKey(e => e.TerritoryId)
                .IsClustered(false);

            entity.Property(e => e.TerritoryId)
                .HasMaxLength(20)
                .HasColumnName("TerritoryID");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.Property(e => e.TerritoryDescription)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength(true);

            entity.HasOne(d => d.Region)
                .WithMany(p => p.Territories)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Territories_Region");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Territory> entity);
    }
}

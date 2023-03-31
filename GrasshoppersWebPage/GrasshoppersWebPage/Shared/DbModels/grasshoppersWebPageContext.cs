﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GrasshoppersWebPage.Shared.DbModels
{
    public partial class grasshoppersWebPageContext : DbContext
    {
        public grasshoppersWebPageContext()
        {
        }

        public grasshoppersWebPageContext(DbContextOptions<grasshoppersWebPageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Player { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("birthDate");

                entity.Property(e => e.FieldPosition)
                    .HasMaxLength(10)
                    .HasColumnName("fieldPosition")
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .HasColumnName("firstName")
                    .IsFixedLength();

                entity.Property(e => e.JerseyNumber).HasColumnName("jerseyNumber");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .HasColumnName("lastName")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId).HasColumnName("playerId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
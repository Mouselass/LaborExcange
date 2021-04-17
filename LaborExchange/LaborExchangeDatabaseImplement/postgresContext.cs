﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LaborExchangeDatabaseImplement.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LaborExchangeDatabaseImplement
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicant> Applicant { get; set; }
        public virtual DbSet<Deal> Deal { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Employer> Employer { get; set; }
        public virtual DbSet<Exchangeemployee> Exchangeemployee { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vacancy> Vacancy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=newuser");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.ToTable("applicant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Birthdaydate)
                    .HasColumnName("birthdaydate")
                    .HasColumnType("date");

                entity.Property(e => e.Educationid).HasColumnName("educationid");

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Workexperience)
                    .IsRequired()
                    .HasColumnName("workexperience")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Applicant)
                    .HasForeignKey(d => d.Educationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("education_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Applicant)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_fkey");
            });

            modelBuilder.Entity<Deal>(entity =>
            {
                entity.ToTable("deal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Applicantid).HasColumnName("applicantid");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Exchangeemployeeid).HasColumnName("exchangeemployeeid");

                entity.Property(e => e.Vacancyid).HasColumnName("vacancyid");

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.Deal)
                    .HasForeignKey(d => d.Applicantid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("applicant_fkey");

                entity.HasOne(d => d.Exchangeemployee)
                    .WithMany(p => p.Deal)
                    .HasForeignKey(d => d.Exchangeemployeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exchangeemployee_fkey");

                entity.HasOne(d => d.Vacancy)
                    .WithMany(p => p.Deal)
                    .HasForeignKey(d => d.Vacancyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vacancy_fkey");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("education");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.ToTable("employer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasColumnName("activity")
                    .HasMaxLength(255);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Employer)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_fkey");
            });

            modelBuilder.Entity<Exchangeemployee>(entity =>
            {
                entity.ToTable("exchangeemployee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Exchangeemployee)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_fkey");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Role).HasColumnName("role");
            });

            modelBuilder.Entity<Vacancy>(entity =>
            {
                entity.ToTable("vacancy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Educationid).HasColumnName("educationid");

                entity.Property(e => e.Employerid).HasColumnName("employerid");

                entity.Property(e => e.Post)
                    .IsRequired()
                    .HasColumnName("post")
                    .HasMaxLength(255);

                entity.Property(e => e.Workexperience)
                    .IsRequired()
                    .HasColumnName("workexperience")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Vacancy)
                    .HasForeignKey(d => d.Educationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("education_fkey");

                entity.HasOne(d => d.Employer)
                    .WithMany(p => p.Vacancy)
                    .HasForeignKey(d => d.Employerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employer_fkey");
            });

            modelBuilder.HasSequence("applicantseq");

            modelBuilder.HasSequence("dealseq");

            modelBuilder.HasSequence("educationseq");

            modelBuilder.HasSequence("employerseq");

            modelBuilder.HasSequence("exchangeemployeeseq");

            modelBuilder.HasSequence("userseq");

            modelBuilder.HasSequence("vacancyseq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

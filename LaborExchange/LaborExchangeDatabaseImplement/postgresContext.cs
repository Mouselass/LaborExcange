using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vacancy> Vacancy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=newuser");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.ToTable("applicant");

                entity.HasIndex(e => e.Educationid)
                    .HasName("edc_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

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

                entity.HasIndex(e => e.Applicantid)
                    .HasName("apl_idx");

                entity.HasIndex(e => e.Employerid)
                    .HasName("emp_idx");

                entity.HasIndex(e => e.Exchangeemployeeid)
                    .HasName("exempl_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Applicantid).HasColumnName("applicantid");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Employerid).HasColumnName("employerid");

                entity.Property(e => e.Exchangeemployeeid).HasColumnName("exchangeemployeeid");

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.Deal)
                    .HasForeignKey(d => d.Applicantid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("applicant_fkey");

                entity.HasOne(d => d.Employer)
                    .WithMany(p => p.Deal)
                    .HasForeignKey(d => d.Employerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employer_fkey");

                entity.HasOne(d => d.Exchangeemployee)
                    .WithMany(p => p.Deal)
                    .HasForeignKey(d => d.Exchangeemployeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exchangeemployee_fkey");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("education");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.ToTable("employer");

                entity.HasIndex(e => e.Userid)
                    .HasName("usr_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

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

                entity.HasIndex(e => e.Userid)
                    .HasName("usre_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

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

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Roleid)
                    .HasName("rol_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("role_fkey");
            });

            modelBuilder.Entity<Vacancy>(entity =>
            {
                entity.ToTable("vacancy");

                entity.HasIndex(e => e.Educationid)
                    .HasName("edcv_idx");

                entity.HasIndex(e => e.Employerid)
                    .HasName("empl_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

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

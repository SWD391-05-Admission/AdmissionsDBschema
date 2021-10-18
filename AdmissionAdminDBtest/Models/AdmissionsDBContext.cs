using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class AdmissionsDBContext : DbContext
    {
        public AdmissionsDBContext()
        {
        }

        public AdmissionsDBContext(DbContextOptions<AdmissionsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdmissionForm> AdmissionForms { get; set; }
        public virtual DbSet<Counselor> Counselors { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Talkshow> Talkshows { get; set; }
        public virtual DbSet<TalkshowTransaction> TalkshowTransactions { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<UniAddress> UniAddresses { get; set; }
        public virtual DbSet<UniAdmission> UniAdmissions { get; set; }
        public virtual DbSet<UniImage> UniImages { get; set; }
        public virtual DbSet<UniMajor> UniMajors { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=AdmissionsDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdmissionForm>(entity =>
            {
                entity.ToTable("AdmissionForm");
            });

            modelBuilder.Entity<Counselor>(entity =>
            {
                entity.ToTable("Counselor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Counselor)
                    .HasForeignKey<Counselor>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Counselor_User");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.District1).HasColumnName("District");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.ToTable("Major");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.ToTable("Rate");

                entity.Property(e => e.Rate1).HasColumnName("Rate");

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.Rates)
                    .HasForeignKey(d => d.Student)
                    .HasConstraintName("FK_Rate_Student");

                entity.HasOne(d => d.TalkshowNavigation)
                    .WithMany(p => p.Rates)
                    .HasForeignKey(d => d.Talkshow)
                    .HasConstraintName("FK__Rate__Talkshow__5441852A");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleName).IsUnicode(false);
            });

            modelBuilder.Entity<Slot>(entity =>
            {
                entity.ToTable("Slot");

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.Slots)
                    .HasForeignKey(d => d.Student)
                    .HasConstraintName("FK_Slot_Student");

                entity.HasOne(d => d.TalkshowNavigation)
                    .WithMany(p => p.Slots)
                    .HasForeignKey(d => d.Talkshow)
                    .HasConstraintName("FK_Slot_Talkshow");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Student)
                    .HasForeignKey<Student>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_User");
            });

            modelBuilder.Entity<Talkshow>(entity =>
            {
                entity.ToTable("Talkshow");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.IsCancel).HasColumnName("isCancel");

                entity.Property(e => e.IsComplete).HasColumnName("isComplete");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.CounselorNavigation)
                    .WithMany(p => p.Talkshows)
                    .HasForeignKey(d => d.Counselor)
                    .HasConstraintName("FK_Talkshow_Counselor");

                entity.HasOne(d => d.MajorNavigation)
                    .WithMany(p => p.Talkshows)
                    .HasForeignKey(d => d.Major)
                    .HasConstraintName("FK_Talkshow_Major");

                entity.HasOne(d => d.UniversityNavigation)
                    .WithMany(p => p.Talkshows)
                    .HasForeignKey(d => d.University)
                    .HasConstraintName("FK_Talkshow_University");
            });

            modelBuilder.Entity<TalkshowTransaction>(entity =>
            {
                entity.ToTable("TalkshowTransaction");

                entity.HasOne(d => d.TalkshowNavigation)
                    .WithMany(p => p.TalkshowTransactions)
                    .HasForeignKey(d => d.Talkshow)
                    .HasConstraintName("FK_TalkshowTransaction_Talkshow");

                entity.HasOne(d => d.TransactionNavigation)
                    .WithMany(p => p.TalkshowTransactions)
                    .HasForeignKey(d => d.Transaction)
                    .HasConstraintName("FK_TalkshowTransaction_Transaction");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.WalletNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.Wallet)
                    .HasConstraintName("FK_Transaction_Wallet");
            });

            modelBuilder.Entity<UniAddress>(entity =>
            {
                entity.ToTable("UniAddress");

                entity.HasOne(d => d.DistrictNavigation)
                    .WithMany(p => p.UniAddresses)
                    .HasForeignKey(d => d.District)
                    .HasConstraintName("FK__UniAddres__Distr__5070F446");

                entity.HasOne(d => d.UniversityNavigation)
                    .WithMany(p => p.UniAddresses)
                    .HasForeignKey(d => d.University)
                    .HasConstraintName("FK__UniAddres__Unive__5165187F");
            });

            modelBuilder.Entity<UniAdmission>(entity =>
            {
                entity.ToTable("UniAdmission");

                entity.HasOne(d => d.AdmissionNavigation)
                    .WithMany(p => p.UniAdmissions)
                    .HasForeignKey(d => d.Admission)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UniAdmission_AdmissionForm");

                entity.HasOne(d => d.UniversityNavigation)
                    .WithMany(p => p.UniAdmissions)
                    .HasForeignKey(d => d.University)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UniAdmission_University");
            });

            modelBuilder.Entity<UniImage>(entity =>
            {
                entity.ToTable("UniImage");

                entity.Property(e => e.IsBanner).HasColumnName("isBanner");

                entity.Property(e => e.IsLogo).HasColumnName("isLogo");

                entity.HasOne(d => d.UniversityNavigation)
                    .WithMany(p => p.UniImages)
                    .HasForeignKey(d => d.University)
                    .HasConstraintName("FK__UniImage__Univer__4BAC3F29");
            });

            modelBuilder.Entity<UniMajor>(entity =>
            {
                entity.ToTable("UniMajor");

                entity.Property(e => e.MajorId).HasColumnName("MajorID");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.UniMajors)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_UniMajor_Major");

                entity.HasOne(d => d.UniversityNavigation)
                    .WithMany(p => p.UniMajors)
                    .HasForeignKey(d => d.University)
                    .HasConstraintName("FK__UniMajor__Univer__5629CD9C");
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.ToTable("University");

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Facebook).IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.LastYearBenchmark).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MaxFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MinFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Website).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__User__RoleId__4F7CD00D");
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.ToTable("Wallet");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.Wallets)
                    .HasForeignKey(d => d.Student)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wallet_Student");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

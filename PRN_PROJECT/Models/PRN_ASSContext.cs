using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace PRN_PROJECT.Models
{
    public partial class PRN_ASSContext : DbContext
    {
        public PRN_ASSContext()
        {
        }

        public PRN_ASSContext(DbContextOptions<PRN_ASSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<Mark> Marks { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                          .SetBasePath(Directory.GetCurrentDirectory())
                                          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(e => new { e.QuestionId, e.Stt })
                    .HasName("PK__Answer__91634F0BF08A4101");

                entity.ToTable("Answer");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Answers).HasColumnName("Answer");

                entity.Property(e => e.ExamCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ExamCodeNavigation)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.ExamCode)
                    .HasConstraintName("FK__Answer__ExamCode__2D27B809");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasPrincipalKey(p => p.QuestionId)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__Question__2C3393D0");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasKey(e => e.ExamCode)
                    .HasName("PK__Exam__FFB9F6CEF3F443F9");

                entity.ToTable("Exam");

                entity.Property(e => e.ExamCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExamSubject)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.HasKey(e => new { e.ExamCode, e.Username })
                    .HasName("PK__Mark__BA8F3E90B241CF2D");

                entity.ToTable("Mark");

                entity.Property(e => e.ExamCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark1).HasColumnName("Mark");

                entity.HasOne(d => d.ExamCodeNavigation)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.ExamCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mark__ExamCode__300424B4");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mark__Username__30F848ED");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => new { e.QuestionId, e.ExamCode })
                    .HasName("PK__Question__F23BF0E03D731D37");

                entity.ToTable("Question");

                entity.HasIndex(e => e.QuestionId, "UQ__Question__0DC06F8D4044A362")
                    .IsUnique();

                entity.Property(e => e.QuestionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("QuestionID");

                entity.Property(e => e.ExamCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnswerDesc).HasMaxLength(255);

                entity.HasOne(d => d.ExamCodeNavigation)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.ExamCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question__ExamCo__29572725");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Student__536C85E55723855D");

                entity.ToTable("Student");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

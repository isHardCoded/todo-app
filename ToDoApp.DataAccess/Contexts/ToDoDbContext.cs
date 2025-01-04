using Microsoft.EntityFrameworkCore;
using ToDoApp.DataAccess.Entities;

namespace ToDoApp.DataAccess.Contexts;

public class ToDoDbContext : DbContext
{
    public ToDoDbContext()
    {
    }

    public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TaskEntity> Tasks { get; set; }

    public virtual DbSet<UserEntity> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskEntity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("User_pkey");

            entity.ToTable("Task");

            entity.HasIndex(e => e.AuthorUserId, "IX_Task_AuthorUserId");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorUserId).HasDefaultValue(1);
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasColumnName("description");
            entity.Property(e => e.EndDate)
                .HasColumnType("time with time zone")
                .HasColumnName("endDate");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.StartDate)
                .HasColumnType("time with time zone")
                .HasColumnName("startDate");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Tags)
                .HasMaxLength(150)
                .HasColumnName("tags");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasColumnName("title");

            entity
                .HasOne(d => d.AssignedUser)
                .WithMany(p => p.TaskAssignedUsers)
                .HasForeignKey(d => d.AssignedUserId);

            entity
                .HasOne(d => d.AuthorUser)
                .WithMany(p => p.TaskAuthorUsers)
                .HasForeignKey(d => d.AuthorUserId);
        });

        modelBuilder.Entity<UserEntity>(entity => { entity.ToTable("User"); });

        modelBuilder.Entity<UserEntity>()
            .HasData(
                new UserEntity
                {
                    Id = 1,
                    UserName = "Test"
                }
            );
    }
}
using Microsoft.EntityFrameworkCore;

namespace Work1.Models;

public partial class Training230982Context : DbContext
{
    public Training230982Context()
    {
    }

    public Training230982Context(DbContextOptions<Training230982Context> options)
        : base(options)
    {
    }

    public virtual DbSet<FaceMask> FaceMasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=10.33.6.52,1434;Initial Catalog=Training_230982;User ID=230982;Password=michaelhyang;Integrated Security=false;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FaceMask>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("FaceMask");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("address");
            entity.Property(e => e.AdultCount).HasColumnName("adult_count");
            entity.Property(e => e.ChildCount).HasColumnName("child_count");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.SourceDatetime)
                .HasColumnType("datetime")
                .HasColumnName("source_datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

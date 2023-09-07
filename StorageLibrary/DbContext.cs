#region Usings
// For UseSqlite():
using static Microsoft.EntityFrameworkCore.SqliteDbContextOptionsBuilderExtensions;

// For HasColumnName():
using static Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions;
#endregion

namespace StorageLibrary;

public class DbContext: Microsoft.EntityFrameworkCore.DbContext
{
    private static string? connectionString = null;

    public Microsoft.EntityFrameworkCore.DbSet<ModelLibrary.Die.FavoredDie>
        FavoredDieDbSet { get; private set; }

    #region Constructors
    public DbContext(): base() {}

    public DbContext(Microsoft.EntityFrameworkCore.DbContextOptions<
        StorageLibrary.DbContext> options): base(options: options) {}
    #endregion

    #region Methods
    protected override void OnConfiguring(
    Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder: optionsBuilder);

        optionsBuilder.UseSqlite(connectionString:
            StorageLibrary.DbContext.connectionString);
    }

    protected override void OnModelCreating(
    Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder: modelBuilder);

        {
            Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<
                ModelLibrary.Die.FavoredDie> entityTypeBuilder = modelBuilder.Entity<
                    ModelLibrary.Die.FavoredDie>();

            entityTypeBuilder.Property(propertyName:
                ModelLibrary.Die.FavoredDie.FavoredDieIdFieldName)
                    .HasColumnName(name: "FavoredDieId");
            entityTypeBuilder.Property(propertyName:
                ModelLibrary.Die.FavoredDie.FavoredFaceFieldName)
                    .HasColumnName(name: "FavoredFace");
            entityTypeBuilder.Property(propertyName:
                ModelLibrary.Die.FavoredDie.FavorFactorFieldName)
                    .HasColumnName(name: "FavorFactor");
        }
    }

    public static void SetConnectionString(string? connectionString) =>
    StorageLibrary.DbContext.connectionString = connectionString;
    #endregion
}
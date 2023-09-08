#region Usings
// For UseSqlite():
using static Microsoft.EntityFrameworkCore.SqliteDbContextOptionsBuilderExtensions;

// For Where() and ToList():
using static System.Linq.Enumerable;

// For HasColumnName():
using static Microsoft.EntityFrameworkCore.RelationalPropertyBuilderExtensions;
#endregion

namespace StorageLibrary;

public class DbContext: Microsoft.EntityFrameworkCore.DbContext
{
    private static string? connectionString = null;

    #region Properties
    public Microsoft.EntityFrameworkCore.DbSet<ModelLibrary.Die.FavoredDie>
        FavoredDieDbSet { get; private set; }

    public Microsoft.EntityFrameworkCore.DbSet<ModelLibrary.Result.FavoredResultPair>
        FavoredResultPairDbSet { get; private set; }
    #endregion

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

        foreach (Microsoft.EntityFrameworkCore.Metadata.IMutableEntityType
        mutableEntityType in modelBuilder.Model.GetEntityTypes())
            mutableEntityType.GetForeignKeys()
                .Where((Microsoft.EntityFrameworkCore.Metadata.IMutableForeignKey
                        mutableForeignKey) =>
                    !mutableForeignKey.IsOwnership &&
                        mutableForeignKey.DeleteBehavior !=
                            Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict)
                .ToList()
                .ForEach((Microsoft.EntityFrameworkCore.Metadata.IMutableForeignKey
                        mutableForeignKey) =>
                    mutableForeignKey.DeleteBehavior =
                        Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);

        static void AddColumn<TEntity>(
        Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TEntity>
            entityTypeBuilder,
        string fieldName, string columnName) where TEntity: class =>
        entityTypeBuilder.Property(propertyName: fieldName)
            .HasColumnName(name: columnName);

        {
            Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<
                ModelLibrary.Die.FavoredDie> entityTypeBuilder =
                    modelBuilder.Entity<ModelLibrary.Die.FavoredDie>();

            AddColumn<ModelLibrary.Die.FavoredDie>(
                entityTypeBuilder: entityTypeBuilder                                 ,
                fieldName        : ModelLibrary.Die.FavoredDie.FavoredDieIdFieldName ,
                columnName       : ModelLibrary.Die.FavoredDie.FavoredDieIdColumnName);
            AddColumn<ModelLibrary.Die.FavoredDie>(
                entityTypeBuilder: entityTypeBuilder                                ,
                fieldName        : ModelLibrary.Die.FavoredDie.FavoredFaceFieldName ,
                columnName       : ModelLibrary.Die.FavoredDie.FavoredFaceColumnName);
            AddColumn<ModelLibrary.Die.FavoredDie>(
                entityTypeBuilder: entityTypeBuilder                                ,
                fieldName        : ModelLibrary.Die.FavoredDie.FavorFactorFieldName ,
                columnName       : ModelLibrary.Die.FavoredDie.FavorFactorColumnName);
        }
        {
            Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<
                ModelLibrary.Result.FavoredResultPair> entityTypeBuilder =
                    modelBuilder.Entity<ModelLibrary.Result.FavoredResultPair>();

            AddColumn<ModelLibrary.Result.FavoredResultPair>(
                entityTypeBuilder: entityTypeBuilder,
                fieldName        :
                    ModelLibrary.Result.FavoredResultPair.FavoredResultPairIdFieldName,
                columnName:
                    ModelLibrary.Result.FavoredResultPair.FavoredResultPairIdColumnName);
            AddColumn<ModelLibrary.Result.FavoredResultPair>(
                entityTypeBuilder: entityTypeBuilder                                   ,
                fieldName        : ModelLibrary.Result.FavoredResultPair.FaceFieldName ,
                columnName       : ModelLibrary.Result.FavoredResultPair.FaceColumnName);
            AddColumn<ModelLibrary.Result.FavoredResultPair>(
                entityTypeBuilder: entityTypeBuilder,
                fieldName        :
                    ModelLibrary.Result.FavoredResultPair.SecondFaceFieldName,
                columnName: ModelLibrary.Result.FavoredResultPair.SecondFaceColumnName);
        }
    }

    public static void SetConnectionString(string? connectionString) =>
    StorageLibrary.DbContext.connectionString = connectionString;
    #endregion
}
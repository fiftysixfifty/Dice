// For UseSqlite():
using static Microsoft.EntityFrameworkCore.SqliteDbContextOptionsBuilderExtensions;

namespace StorageLibrary;

public class DbContext: Microsoft.EntityFrameworkCore.DbContext
{
    private static string? connectionString = null;

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

    public static void SetConnectionString(string? connectionString) =>
    StorageLibrary.DbContext.connectionString = connectionString;
    #endregion
}
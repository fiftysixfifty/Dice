using MVCViewProject.Models        ;
using Microsoft.EntityFrameworkCore;

namespace MVCViewProject.Storage;

public class DbContext: Microsoft.EntityFrameworkCore.DbContext
{
    private static System.String? connectionString = null;

    public DbSet<PairRoll> PairRollDbSet { get; private set; }

    #region Constructors
    public DbContext(): base() {}

    public DbContext(DbContextOptions<DbContext> options): base(options: options) {}
    #endregion

    #region Methods
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder: optionsBuilder);

        optionsBuilder.UseSqlite(connectionString: DbContext.connectionString);
    }

    internal static void SetConnectionString(System.String? connectionString) =>
    DbContext.connectionString = connectionString;
    #endregion
}
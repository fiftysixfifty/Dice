namespace ServiceLibrary.Die;

internal static class FavoredDie
{
    internal static int Add(
    StorageLibrary.DbContext    dbContext ,
    ModelLibrary.Die.FavoredDie favoredDie)
    {
        dbContext.FavoredDieDbSet.Add(entity: favoredDie);
        dbContext.SaveChanges();

        return favoredDie.FavoredDieId;
    }
}
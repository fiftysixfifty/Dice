namespace ServiceLibrary.Result;

public static class FavoredResultPair
{
    public static ModelLibrary.Result.FavoredResultPairList Add(
    ModelLibrary.Result.FavoredResultPairList favoredResultPairList)
    {
        if (favoredResultPairList.Count > 0)
        {
            ModelLibrary.Die.FavoredDie? firstFavoredDie, secondFavoredDie;
            {
                ModelLibrary.Result.FavoredResultPair firstFavoredResultPair =
                    favoredResultPairList[index: 0];

                firstFavoredDie  = firstFavoredResultPair.FirstFavoredDie ;
                secondFavoredDie = firstFavoredResultPair.SecondFavoredDie;
            }

            if (null == firstFavoredDie || null == secondFavoredDie)
                throw new System.ArgumentNullException();
            else
                using (StorageLibrary.DbContext dbContext = new StorageLibrary.DbContext())
                {
                    {
                        int
                            firstFavoredDieId = ServiceLibrary.Die.FavoredDie.Add(
                                dbContext: dbContext, favoredDie: firstFavoredDie),
                            secondFavoredDieId = ServiceLibrary.Die.FavoredDie.Add(
                                dbContext: dbContext, favoredDie: secondFavoredDie);

                        foreach (ModelLibrary.Result.FavoredResultPair
                        favoredResultPair in favoredResultPairList)
                        {
                            favoredResultPair.FirstFavoredDieId  = firstFavoredDieId ;
                            favoredResultPair.SecondFavoredDieId = secondFavoredDieId;
                        }
                    }

                    dbContext.FavoredResultPairDbSet.AddRange(
                        entities: favoredResultPairList);
                    dbContext.SaveChanges();
                }
        }

        return favoredResultPairList;
    }
}
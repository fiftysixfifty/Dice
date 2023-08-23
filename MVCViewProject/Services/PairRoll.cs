using MVCViewProject.Models ;
using MVCViewProject.Storage;

namespace MVCViewProject.Services;

internal static class PairRoll
{
    internal static PairRollList Add(PairRollList pairRollList)
    {
        if (pairRollList.Count > 0)
            using (DbContext dbContext = new DbContext())
            {
                foreach (MVCViewProject.Models.PairRoll pairRoll in pairRollList)
                    dbContext.PairRollDbSet.Add(entity: pairRoll);

                dbContext.SaveChanges();
            }

        return pairRollList;
    }
}
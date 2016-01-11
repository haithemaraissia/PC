using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.RatingCodes;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeRatingCodeRepository : FakeGenericRepository<RatingCode>, IRatingCodeRepository
    {
	    public FakeRatingCodeRepository(): base(new FakeRatingCode().MyRatingCodes)
        {
        }

        public FakeRatingCodeRepository(List<RatingCode> myRatingCodes)
            : base(myRatingCodes)
        {
        }
    }
}
       
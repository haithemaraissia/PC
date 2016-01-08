using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class RatingCodeRepository : FakeGenericRepository<RatingCode>, IRatingCodeRepository
    {
	    public RatingCodeRepository(): base(new FakeRatingCodes().MyRatingCodes)
        {
        }

        public RatingCodeRepository(List<RatingCode> myRatingCodes): base(myRatingCodes)
        {
        }
    }
}
       
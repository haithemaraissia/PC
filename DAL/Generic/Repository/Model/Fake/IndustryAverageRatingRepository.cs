using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Industry;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeIndustryAverageRatingRepository : FakeGenericRepository<IndustryAverageRating>, IIndustryAverageRatingRepository
    {
        public FakeIndustryAverageRatingRepository()
            : base(new FakeIndustryAverageRatings().MyIndustryAverageRatings)
        {
        }

        public FakeIndustryAverageRatingRepository(List<IndustryAverageRating> myIndustryAverageRatings)
            : base(myIndustryAverageRatings)
        {
        }
    }
}
       
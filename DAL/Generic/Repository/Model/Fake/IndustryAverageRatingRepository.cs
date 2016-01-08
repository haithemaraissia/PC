using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class IndustryAverageRatingRepository : FakeGenericRepository<IndustryAverageRating>, IIndustryAverageRatingRepository
    {
	    public IndustryAverageRatingRepository(): base(new FakeIndustryAverageRatings().MyIndustryAverageRatings)
        {
        }

        public IndustryAverageRatingRepository(List<IndustryAverageRating> myIndustryAverageRatings): base(myIndustryAverageRatings)
        {
        }
    }
}
       
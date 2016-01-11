using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Promotions;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakePromotionRepository : FakeGenericRepository<Promotion>, IPromotionRepository
    {
	    public FakePromotionRepository(): base(new FakePromotions().MyPromotions)
        {
        }

        public FakePromotionRepository(List<Promotion> myPromotions)
            : base(myPromotions)
        {
        }
    }
}
       
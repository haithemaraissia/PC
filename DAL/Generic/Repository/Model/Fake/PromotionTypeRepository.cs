using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Promotions;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakePromotionTypeRepository : FakeGenericRepository<PromotionType>, IPromotionTypeRepository
    {
	    public FakePromotionTypeRepository(): base(new FakePromotionTypes().MyPromotionType)
        {
        }

        public FakePromotionTypeRepository(List<PromotionType> myPromotionTypes)
            : base(myPromotionTypes)
        {
        }
    }
}
       
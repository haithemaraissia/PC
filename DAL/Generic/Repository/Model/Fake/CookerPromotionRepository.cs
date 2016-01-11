using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerPromotionRepository : FakeGenericRepository<CookerPromotion>, ICookerPromotionRepository
    {
	    public FakeCookerPromotionRepository(): base(new FakeCookerPromotions().MyCookerPromotions)
        {
        }

        public FakeCookerPromotionRepository(List<CookerPromotion> myCookerPromotions)
            : base(myCookerPromotions)
        {
        }
    }
}
       
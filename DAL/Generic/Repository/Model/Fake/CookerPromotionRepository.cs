using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerPromotionRepository : FakeGenericRepository<CookerPromotion>, ICookerPromotionRepository
    {
	    public CookerPromotionRepository(): base(new FakeCookerPromotions().MyCookerPromotions)
        {
        }

        public CookerPromotionRepository(List<CookerPromotion> myCookerPromotions): base(myCookerPromotions)
        {
        }
    }
}
       
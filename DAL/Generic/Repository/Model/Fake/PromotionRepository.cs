using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class PromotionRepository : FakeGenericRepository<Promotion>, IPromotionRepository
    {
	    public PromotionRepository(): base(new FakePromotions().MyPromotions)
        {
        }

        public PromotionRepository(List<Promotion> myPromotions): base(myPromotions)
        {
        }
    }
}
       
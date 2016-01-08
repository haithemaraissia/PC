using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class PromotionTypeRepository : FakeGenericRepository<PromotionType>, IPromotionTypeRepository
    {
	    public PromotionTypeRepository(): base(new FakePromotionTypes().MyPromotionTypes)
        {
        }

        public PromotionTypeRepository(List<PromotionType> myPromotionTypes): base(myPromotionTypes)
        {
        }
    }
}
       
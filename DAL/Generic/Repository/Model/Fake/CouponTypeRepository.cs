using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Coupons;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCouponTypeRepository : FakeGenericRepository<CouponType>, ICouponTypeRepository
    {
	    public FakeCouponTypeRepository(): base(new FakeCouponTypes().MyCouponType)
        {
        }

        public FakeCouponTypeRepository(List<CouponType> myCouponTypes)
            : base(myCouponTypes)
        {
        }
    }
}
       
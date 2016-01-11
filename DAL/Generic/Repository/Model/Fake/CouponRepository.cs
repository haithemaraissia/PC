using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Coupons;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCouponRepository : FakeGenericRepository<Coupon>, ICouponRepository
    {
	    public FakeCouponRepository(): base(new FakeCoupons().MyCoupons)
        {
        }

        public FakeCouponRepository(List<Coupon> myCoupons)
            : base(myCoupons)
        {
        }
    }
}
       
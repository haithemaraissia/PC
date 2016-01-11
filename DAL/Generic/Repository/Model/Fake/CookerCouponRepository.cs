using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerCouponRepository : FakeGenericRepository<CookerCoupon>, ICookerCouponRepository
    {
	    public FakeCookerCouponRepository(): base(new FakeCookerCoupon().MyCookerCoupons)
        {
        }

        public FakeCookerCouponRepository(List<CookerCoupon> myCookerCoupons)
            : base(myCookerCoupons)
        {
        }
    }
}
       
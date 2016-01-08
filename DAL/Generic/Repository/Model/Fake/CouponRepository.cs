using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CouponRepository : FakeGenericRepository<Coupon>, ICouponRepository
    {
	    public CouponRepository(): base(new FakeCoupons().MyCoupons)
        {
        }

        public CouponRepository(List<Coupon> myCoupons): base(myCoupons)
        {
        }
    }
}
       
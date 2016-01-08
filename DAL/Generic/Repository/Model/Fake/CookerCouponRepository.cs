using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerCouponRepository : FakeGenericRepository<CookerCoupon>, ICookerCouponRepository
    {
	    public CookerCouponRepository(): base(new FakeCookerCoupons().MyCookerCoupons)
        {
        }

        public CookerCouponRepository(List<CookerCoupon> myCookerCoupons): base(myCookerCoupons)
        {
        }
    }
}
       
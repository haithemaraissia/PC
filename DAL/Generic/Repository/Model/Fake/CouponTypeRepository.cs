using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CouponTypeRepository : FakeGenericRepository<CouponType>, ICouponTypeRepository
    {
	    public CouponTypeRepository(): base(new FakeCouponTypes().MyCouponTypes)
        {
        }

        public CouponTypeRepository(List<CouponType> myCouponTypes): base(myCouponTypes)
        {
        }
    }
}
       
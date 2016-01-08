using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class CookerSubscriptionRepository : FakeGenericRepository<CookerSubscription>, ICookerSubscriptionRepository
    {
	    public CookerSubscriptionRepository(): base(new FakeCookerSubscriptions().MyCookerSubscriptions)
        {
        }

        public CookerSubscriptionRepository(List<CookerSubscription> myCookerSubscriptions): base(myCookerSubscriptions)
        {
        }
    }
}
       
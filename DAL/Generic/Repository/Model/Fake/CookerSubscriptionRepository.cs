using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Subscriptions.Cookers;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeCookerSubscriptionRepository : FakeGenericRepository<CookerSubscription>, ICookerSubscriptionRepository
    {
	    public FakeCookerSubscriptionRepository(): base(new FakeCookerSubscriptions().MyCookerSubscriptions)
        {
        }

        public FakeCookerSubscriptionRepository(List<CookerSubscription> myCookerSubscriptions)
            : base(myCookerSubscriptions)
        {
        }
    }
}
       
using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Subscriptions.Clients;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeClientSubscriptionRepository : FakeGenericRepository<ClientSubscription>, IClientSubscriptionRepository
    {
	    public FakeClientSubscriptionRepository(): base(new FakeClientSubscription().MyClientSubscriptions)
        {
        }

        public FakeClientSubscriptionRepository(List<ClientSubscription> myClientSubscriptions)
            : base(myClientSubscriptions)
        {
        }
    }
}
       
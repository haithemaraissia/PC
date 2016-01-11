using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.MostPopularSubscription;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeMostPopularSubscriptionRepository : FakeGenericRepository<MostPopularSubscription>, IMostPopularSubscriptionRepository
    {
	    public FakeMostPopularSubscriptionRepository(): base(new FakeMostPopularSubscriptions().MyMostPopularSubscriptions)
        {
        }

        public FakeMostPopularSubscriptionRepository(List<MostPopularSubscription> myMostPopularSubscriptions)
            : base(myMostPopularSubscriptions)
        {
        }
    }
}
       
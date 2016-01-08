using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class MostPopularSubscriptionRepository : FakeGenericRepository<MostPopularSubscription>, IMostPopularSubscriptionRepository
    {
	    public MostPopularSubscriptionRepository(): base(new FakeMostPopularSubscriptions().MyMostPopularSubscriptions)
        {
        }

        public MostPopularSubscriptionRepository(List<MostPopularSubscription> myMostPopularSubscriptions): base(myMostPopularSubscriptions)
        {
        }
    }
}
       
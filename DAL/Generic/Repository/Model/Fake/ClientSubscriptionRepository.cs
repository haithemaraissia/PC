using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ClientSubscriptionRepository : FakeGenericRepository<ClientSubscription>, IClientSubscriptionRepository
    {
	    public ClientSubscriptionRepository(): base(new FakeClientSubscriptions().MyClientSubscriptions)
        {
        }

        public ClientSubscriptionRepository(List<ClientSubscription> myClientSubscriptions): base(myClientSubscriptions)
        {
        }
    }
}
       
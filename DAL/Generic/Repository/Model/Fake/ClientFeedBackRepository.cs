using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Reviews.Clients;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeClientFeedBackRepository : FakeGenericRepository<ClientFeedBack>, IClientFeedBackRepository
    {
	    public FakeClientFeedBackRepository(): base(new FakeClientFeedbacks().MyClientsFakeClientFeedbacks)
        {
        }

        public FakeClientFeedBackRepository(List<ClientFeedBack> myClientFeedBacks)
            : base(myClientFeedBacks)
        {
        }
    }
}
       
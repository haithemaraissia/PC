using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ClientFeedBackRepository : FakeGenericRepository<ClientFeedBack>, IClientFeedBackRepository
    {
	    public ClientFeedBackRepository(): base(new FakeClientFeedBacks().MyClientFeedBacks)
        {
        }

        public ClientFeedBackRepository(List<ClientFeedBack> myClientFeedBacks): base(myClientFeedBacks)
        {
        }
    }
}
       
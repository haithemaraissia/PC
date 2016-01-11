using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Clients;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeClientRepository : FakeGenericRepository<Client>, IClientRepository
    {
	    public FakeClientRepository(): base(new FakeClients().MyClients)
        {
        }

        public FakeClientRepository(List<Client> myClients)
            : base(myClients)
        {
        }
    }
}
       
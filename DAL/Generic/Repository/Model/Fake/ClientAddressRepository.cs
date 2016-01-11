using System.Collections.Generic;
using DAL.Fake.Generic;
using DAL.Fake.Model.GoodData.Clients.Address;
using Model;

namespace DAL.Generic.Repository.Model.Fake
{
    public class FakeClientAddressRepository : FakeGenericRepository<ClientAddress>, IClientAddressRepository
    {
	    public FakeClientAddressRepository(): base(new FakeClientAddress().MyClientAddress)
        {
        }

        public FakeClientAddressRepository(List<ClientAddress> myClientAddresss)
            : base(myClientAddresss)
        {
        }
    }
}
       
using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ClientAddressRepository : FakeGenericRepository<ClientAddress>, IClientAddressRepository
    {
	    public ClientAddressRepository(): base(new FakeClientAddresss().MyClientAddresss)
        {
        }

        public ClientAddressRepository(List<ClientAddress> myClientAddresss): base(myClientAddresss)
        {
        }
    }
}
       
using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ClientRepository : FakeGenericRepository<Client>, IClientRepository
    {
	    public ClientRepository(): base(new FakeClients().MyClients)
        {
        }

        public ClientRepository(List<Client> myClients): base(myClients)
        {
        }
    }
}
       
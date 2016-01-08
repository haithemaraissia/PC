using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ClientAddress1Repository : FakeGenericRepository<ClientAddress1>, IClientAddress1Repository
    {
	    public ClientAddress1Repository(): base(new FakeClientAddress1s().MyClientAddress1s)
        {
        }

        public ClientAddress1Repository(List<ClientAddress1> myClientAddress1s): base(myClientAddress1s)
        {
        }
    }
}
       
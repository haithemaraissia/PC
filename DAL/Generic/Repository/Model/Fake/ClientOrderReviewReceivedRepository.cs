using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ClientOrderReviewReceivedRepository : FakeGenericRepository<ClientOrderReviewReceived>, IClientOrderReviewReceivedRepository
    {
	    public ClientOrderReviewReceivedRepository(): base(new FakeClientOrderReviewReceiveds().MyClientOrderReviewReceiveds)
        {
        }

        public ClientOrderReviewReceivedRepository(List<ClientOrderReviewReceived> myClientOrderReviewReceiveds): base(myClientOrderReviewReceiveds)
        {
        }
    }
}
       
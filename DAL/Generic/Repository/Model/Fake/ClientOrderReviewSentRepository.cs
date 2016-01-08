using System.Collections.Generic;
using DAL.Fake.Generic;
using Model;

namespace DAL.Generic.Repository.Model
{
    public partial class ClientOrderReviewSentRepository : FakeGenericRepository<ClientOrderReviewSent>, IClientOrderReviewSentRepository
    {
	    public ClientOrderReviewSentRepository(): base(new FakeClientOrderReviewSents().MyClientOrderReviewSents)
        {
        }

        public ClientOrderReviewSentRepository(List<ClientOrderReviewSent> myClientOrderReviewSents): base(myClientOrderReviewSents)
        {
        }
    }
}
       
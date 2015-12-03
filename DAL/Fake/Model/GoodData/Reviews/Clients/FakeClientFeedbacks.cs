using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Reviews.Clients
{
    public class FakeClientFeedbacks
    {
        public List<ClientFeedBack> MyClientsFakeClientFeedbacks;

        public FakeClientFeedbacks()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyClientsFakeClientFeedbacks = new List<ClientFeedBack> {
                FirstClientFeedback(), 
            };
        }

        public ClientFeedBack FirstClientFeedback()
        {
            var firstClientFeedback = new ClientFeedBack
            {
                ClientFeedBackId = 1,
                ClientId = 1,
                ClientName = "Jack Smith",
                TransactionsCount = 1,
                ReviewScore = 3,
                PositiveReview = (decimal) 0.20
            };
            return firstClientFeedback;
        }


        ~FakeClientFeedbacks()
        {
            MyClientsFakeClientFeedbacks = null;
        }
    }
}

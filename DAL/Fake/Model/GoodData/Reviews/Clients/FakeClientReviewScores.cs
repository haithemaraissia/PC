using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.Clients
{
    public class FakeClientReviewScore
    {
        public List<ClientReviewScore> MyClientReviewScore;

        public FakeClientReviewScore()
        {
            InitializeClientList();
        }

        public void InitializeClientList()
        {
            MyClientReviewScore = new List<ClientReviewScore> {
                FirstClientReviewScore()
            };
        }

        private ClientReviewScore FirstClientReviewScore()
        {
            var firstClientReviewScore = new ClientReviewScore
            {
                ClientReviewScoreId = 1,
                ClientId = 1,
                PositiveReview = 1,
                NegativeReview = 0,
                NeutralReview = 0,
                OrderDate = DateTime.Today.Date
            };
            return firstClientReviewScore;
        }

        ~FakeClientReviewScore()
        {
            MyClientReviewScore = null;
        }
    }
}

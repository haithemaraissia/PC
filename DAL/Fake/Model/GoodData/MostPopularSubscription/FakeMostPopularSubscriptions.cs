using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Plan
{
    public class FakeMostPopularSubscriptions
    {
        public List<global::Model.MostPopularSubscription> MyMostPopularSubscriptions;

        public FakeMostPopularSubscriptions()
        {
            InitializeMostPopularSubscriptionsList();
        }

        public void InitializeMostPopularSubscriptionsList()
        {
            MyMostPopularSubscriptions = new List<global::Model.MostPopularSubscription> {
                FirstSubscription(), 
                SecondSubscription(),
                ThirdSubscription()
            };
        }

        public global::Model.MostPopularSubscription FirstSubscription()
        {
            var firstSubscription = new global::Model.MostPopularSubscription
            {
                CookerSubscriptionId = 2,
                SubscriptionOrderCount = 7
            };
            return firstSubscription;
        }

        public global::Model.MostPopularSubscription SecondSubscription()
        {
            var secondSubscription = new global::Model.MostPopularSubscription
            {
                CookerSubscriptionId = 4,
                SubscriptionOrderCount = 4
            };
            return secondSubscription;
        }

        public global::Model.MostPopularSubscription ThirdSubscription()
        {
            var thirdSubscription = new global::Model.MostPopularSubscription
            {
                CookerSubscriptionId = 3,
                SubscriptionOrderCount = 1
            };
            return thirdSubscription;
        }


        ~FakeMostPopularSubscriptions()
        {
            MyMostPopularSubscriptions = null;
        }
    }
}

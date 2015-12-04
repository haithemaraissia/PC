using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model.GoodData.CookerSubscriptions
{
    public class FakeCookerSubscriptions
    {
        public List<CookerSubscription> MyCookerSubscriptions;

        public FakeCookerSubscriptions()
        {
            InitializeCookerSubscriptionList();
        }

        public void InitializeCookerSubscriptionList()
        {
            MyCookerSubscriptions = new List<CookerSubscription> {
                FirstCookerSubscription(), 
                SecondCookerSubscription(),
                ThirdCookerSubscription()
            };
        }

        public CookerSubscription FirstCookerSubscription()
        {
            var firstCookerSubscription = new CookerSubscription
            {
                CookerSubscriptionId = 1,
                CookerId = 1,
                PlanId = 1,
                ServingPriceId = 1
            };
            return firstCookerSubscription;
        }

        public CookerSubscription SecondCookerSubscription()
        {
            var secondCookerSubscription = new CookerSubscription
            {
                CookerSubscriptionId = 2,
                CookerId = 1,
                PlanId = 1,
                ServingPriceId = 3
            };
            return secondCookerSubscription;
        }

        public CookerSubscription ThirdCookerSubscription()
        {
            var thirdCookerSubscription = new CookerSubscription
            {
                CookerSubscriptionId = 3,
                CookerId = 1,
                PlanId = 1,
                ServingPriceId = 3
            };
            return thirdCookerSubscription;
        }

        ~FakeCookerSubscriptions()
        {
            MyCookerSubscriptions = null;
        }
    }
}

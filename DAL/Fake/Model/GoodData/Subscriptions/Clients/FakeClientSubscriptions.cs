using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeClientSubscription
    {
        public List<ClientSubscription> MyClientSubscriptions;

        public FakeClientSubscription()
        {
            InitializeClientSubscriptionList();
        }

        public void InitializeClientSubscriptionList()
        {
            MyClientSubscriptions = new List<ClientSubscription> {
                FirstClientSubscription(), 
                SecondClientSubscription(),
                ThirdClientSubscription()
            };
        }

        public ClientSubscription FirstClientSubscription()
        {
            var firstClientSubscription = new ClientSubscription
            {
                ClientSubscriptionId = 1,
                ClientId = 1,
                CookerSubscriptionId = 1,
                Active = true,
                ValidUntil = DateTime.Today.AddMonths(1).Date
            };
            return firstClientSubscription;
        }

        public ClientSubscription SecondClientSubscription()
        {
            var secondClientSubscription = new ClientSubscription
            {
                ClientSubscriptionId = 2,
                ClientId = 1,
                CookerSubscriptionId = 3,
                Active = true,
                ValidUntil = DateTime.Today.AddMonths(12).Date
            };
            return secondClientSubscription;
        }

        public ClientSubscription ThirdClientSubscription()
        {
            var thirdClientSubscription = new ClientSubscription
            {
                ClientSubscriptionId = 3,
                ClientId = 2,
                CookerSubscriptionId = 1,
                Active = false,
                ValidUntil = DateTime.Today.AddMonths(-1).Date
            };
            return thirdClientSubscription;
        }

        ~FakeClientSubscription()
        {
            MyClientSubscriptions = null;
        }
    }
}

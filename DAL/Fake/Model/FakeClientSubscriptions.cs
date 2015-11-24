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
                //UserId = 3
            };
            return firstClientSubscription;
        }

        public ClientSubscription SecondClientSubscription()
        {
            var secondClientSubscription = new ClientSubscription
            {
                ClientSubscriptionId = 2,
                //UserId = 4
            };
            return secondClientSubscription;
        }

        public ClientSubscription ThirdClientSubscription()
        {
            var thirdClientSubscription = new ClientSubscription
            {
                ClientSubscriptionId = 3,
                //UserId = 6
            };
            return thirdClientSubscription;
        }

        ~FakeClientSubscription()
        {
            MyClientSubscriptions = null;
        }
    }
}

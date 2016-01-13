using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Fake.Model.GoodData.Cookers;
using DAL.Fake.Model.GoodData.Reviews.Clients;
using DAL.Fake.Model.GoodData.Subscriptions.Clients;
using DAL.Fake.Model.GoodData.Subscriptions.Cookers;
using DAL.Generic.UnitofWork;
using Model;
using OrderModelType = DAL.Fake.Model.LookUp.OrderModel.OrderModelType;

namespace DAL.Fake.Model.Util.Subscriptions
{
    public class SubscriptionHelper
    {
        private readonly List<ClientSubscription> _myClientSubscriptions;
        private readonly List<CookerSubscription> _myCookerSubscriptions;
        private readonly List<ClientOrderToReview> _myClientOrdersToReview;
        private readonly List<ServingPrice> _myCookerServingsPrice;

        private readonly List<Cooker> _cookers;


        public SubscriptionHelper()
        {
            _myClientSubscriptions = new FakeClientSubscription().MyClientSubscriptions;
            _myClientOrdersToReview = new FakeClientOrderToReview().MyClientOrderToReview;
            _myCookerSubscriptions = new FakeCookerSubscriptions().MyCookerSubscriptions;
            _myCookerServingsPrice = new FakeServingPrices().MyServingPricings;
            _cookers = new FakeCookers().MyCookers;
        }

        public SubscriptionHelper(UnitofWork uow)
        {
            _myClientSubscriptions = uow.ClientSubscriptionRepository.All.ToList();

            _myClientOrdersToReview = uow.ClientOrderToReviewRepository.All.ToList();
            _myCookerSubscriptions = uow.CookerSubscriptionRepository.All.ToList();
            _myCookerServingsPrice = uow.ServingPriceRepository.All.ToList();
            _cookers = new FakeCookers().MyCookers;
        }


        #region Common Utility

        public ServingPrice GetCookerServingPriceModel(int clientSubscriptionId)
        {

            var cookerSubscription =
                GetCookerSubscription(clientSubscriptionId);
            return
                (from c in _myCookerServingsPrice
                 where cookerSubscription != null && c.ServicePriceId == cookerSubscription.ServingPriceId
                 select c).FirstOrDefault();
        }

        public CookerSubscription GetCookerSubscription(int clientSubscriptionId)
        {
            var clientSubscription =
                (from c in _myClientSubscriptions
                 where c.ClientSubscriptionId == clientSubscriptionId select c).FirstOrDefault();

            return
                 (from c in _myCookerSubscriptions
                  where clientSubscription != null && c.CookerSubscriptionId == clientSubscription.CookerSubscriptionId
                  select c).FirstOrDefault();
        }

        public ClientOrderToReview CreateOrderReview(Dish selectedDish, int orderSubscriptionId)
        {
            var clientOrderToReviewId = _myClientOrdersToReview.Max(c => c.ClientOrderToReviewId) + 1;
            var newClientOrderToReview = new ClientOrderToReview
            {
                ClientOrderToReviewId = clientOrderToReviewId,
                ClientId = 1,
                CookerId = selectedDish.CookerId,
                MenuId = selectedDish.MenuId,
                OrderId = orderSubscriptionId,
                OrderDate = DateTime.Today.Date,
                OrderModelTypeId = (int)OrderModelType.Values.Subscription
            };
            _myClientOrdersToReview.Add(newClientOrderToReview);
            return newClientOrderToReview;
        }


        public decimal GetTaxPercent(int cookerId)
        {
            return new Common.Util().GetTaxPercent(cookerId);
        }

        public string GetPlanTitle(int? planId)
        {
            return new Common.Util().GetPlanTitle(planId);
        }
        #endregion

    }
}

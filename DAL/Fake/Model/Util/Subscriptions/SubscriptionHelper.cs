using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Fake.Model.GoodData.Cooker;
using DAL.Fake.Model.GoodData.CookerSubscriptions;
using DAL.Fake.Model.GoodData.DeliveryZones;
using DAL.Fake.Model.GoodData.Orders.Clients;
using DAL.Fake.Model.GoodData.OrderTypes;
using DAL.Fake.Model.GoodData.PaymentMethods;
using DAL.Fake.Model.GoodData.Plan;
using DAL.Fake.Model.GoodData.Reviews.Clients;
using Model;

namespace DAL.Fake.Model.Util.Subscriptions
{
    public class SubscriptionHelper
    {
        private List<ClientSubscription> _myClientSubscriptions;
        private List<CookerSubscription> _myCookerSubscriptions;
        private List<ClientOrderToReview> _myClientOrdersToReview;
        private List<ServingPrice> _myCookerServingsPrice;



        private  List<Cooker> _cookers;
        private  List<OrderItem> _orderItem;
        private  List<DeliveryZone> _deliveryZones;
        private  List<CookerDeliveryZone> _cookerDeliveryZones;

        private  ClientAddress _deliveryAddress;

        private  List<PaymentMethod> _fakePaymentMethods;
        private  List<global::Model.OrderType> _fakeOrderTypes;
        private List<Plan> _fakePlans;
        private List<ClientSubscription> FakeClientSubscription = new FakeClientSubscription().MyClientSubscriptions;
        private List<CookerSubscription> FakeCookerSubscription = new FakeCookerSubscriptions().MyCookerSubscriptions;


        public SubscriptionHelper()
        {
            _myClientSubscriptions = new FakeClientSubscription().MyClientSubscriptions;
            _myClientOrdersToReview = new FakeClientOrderToReview().MyClientOrderToReview;
            _myCookerSubscriptions = new FakeCookerSubscriptions().MyCookerSubscriptions;
            _myCookerServingsPrice = new FakeServingPrices().MyServingPricings;


            _cookers = new FakeCookers().MyCookers;
            _orderItem = new FakeOrderItems().MyOrderItems;
            _deliveryZones = new FakeDeliveryZone().MyDeliveryZones;
            _cookerDeliveryZones = new FakeCookerDeliveryZone().MyCookerDeliveryZones;
            _fakePaymentMethods = new FakePaymentMethods().MyPaymentMethods;
            _fakeOrderTypes = new FakeOrderTypes().MyOrderTypes;
            _fakePlans = new FakePlans().MyPlans;
        }


        #region Common Utility

        public ServingPrice GetCookerServingPriceModel(int clientSubscriptionId)
        {
            var clientSubscription =
                (from c in _myClientSubscriptions
                 where c.ClientSubscriptionId == clientSubscriptionId
                 select c).FirstOrDefault();

            var cookerSubscription =
                (from c in _myCookerSubscriptions
                 where clientSubscription != null && c.CookerSubscriptionId == clientSubscription.CookerSubscriptionId
                 select c).FirstOrDefault();

            return
                (from c in _myCookerServingsPrice
                 where cookerSubscription != null && c.ServicePriceId == cookerSubscription.ServingPriceId
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
                OrderModelTypeId = (int)Util.OrderModelType.Values.Subscription
            };
            _myClientOrdersToReview.Add(newClientOrderToReview);
            return newClientOrderToReview;
        }

        #endregion

    }
}

using System;
using System.Diagnostics;
using System.Linq;
using DAL.Fake.Model.GoodData.Cookers.Dishes.Cooker;
using DAL.Fake.Model.LookUp.Currency;
using DAL.Fake.Model.LookUp.OrderStatu;
using DAL.Fake.Model.LookUp.PaymentMethod;
using DAL.Fake.Model.LookUp.PaymentStatus;
using DAL.Fake.Model.LookUp.Week;
using DAL.Fake.Model.Util.Subscriptions;
using DAL.Generic.UnitofWork;
using DAL.Generic.UnitofWork.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using OrderType = DAL.Fake.Model.LookUp.OrderType.OrderType;

namespace Test.Scenario
{
    /// <summary>
    /// Scenario:
    ///     STEP 1
    ///         Client subscribe to a cooker subscription
    ///         Client check the subscription detail
    ///         An Invoice is genereated
    ///         Client Pay Subscription Invoice

    ///     STEP 2
    ///         Cooker Update Subscription Order status to Incoming 
    ///         Cooker Update Subscription Order status to Active

    ///     STEP 3
    ///         Client submit a review for the first dish in the subscription for week 1
    ///         Cooker Submit review for the first dish in the subscription for week 1
    ///         Cooker review is calculated for subscriptions based on dish1 of week1 
    /// </summary>


    [TestClass]
    public class SubscriptionOrder
    {
        private UnitofWork _uow;


        [TestInitialize]
        public void Initialize()
        {
            // Arrange
            //var cookerRepo = new FakeCookerRepository();
            // var uow = new UnitofWorkHelper().GetAllRepository();
            // Controller = new OwnersController(uow);//
            _uow = new UnitofWorkHelper().GetAllRepository();
        }


        [TestMethod]
        public void Steps()
        {
            #region Step1
            var newClientSubscription = ClientSubscribeToCookerSubscription();
            ChecktheSubscriptionDetail();
            var subscriptionInvoice = GenerateInvoiceForSubscription(newClientSubscription);
            AddInvoiceToClient(subscriptionInvoice);
            ClientPaySubscriptionInvoice(subscriptionInvoice);
            #endregion

            #region Step2
            CookerUpdateSubscriptionOrderstatusToIncoming(subscriptionInvoice.OrderId);
            CookerUpdateSubscriptionOrderstatusToDone(subscriptionInvoice.OrderId);
            #endregion

            #region Step3
//            ClientSubmitReviewForFirstDishInSubscriptionForWeek1(subscriptionInvoice.OrderId);


            #endregion


        }


        #region Step1 

        #region ClientSubscribeToCookerSubscription

        private ClientSubscription ClientSubscribeToCookerSubscription()
        {
            var cookerSubscriptionCount = _uow.CookerSubscriptionRepository.All.Count();
            var clientSubscriptionCount = _uow.ClientSubscriptionRepository.All.Count();
            Assert.AreEqual(clientSubscriptionCount, 3);
            Assert.AreEqual(cookerSubscriptionCount, 3);

            #region GIVEN

            #region CookerSubscriptionDetailInformation

            //Cooker Subscription is the following:
            //var secondCookerSubscription = new CookerSubscription
            //{
            //    CookerSubscriptionId = 2,
            //    CookerId = 1,
            //    PlanId = (int)LookUp.Plans.Plans.Types.FiveMealsPerWeek,
            //    ServingPriceId = (int)ServingPriceModel.Values.Fourteen_Dollars_NintyNine
            //};

            #endregion

            #region Client Information

            //var secondClient = new Client
            //{
            //    ClientId = 2,
            //    UserId = 4
            //};


            //   var fourthUser = new User
            //{
            //    UserId = 4,
            //    FirstName = "Robert",
            //    LastName = "Lone",
            //    EmailAddress = "robertlone@yahoo.com",
            //    UserTypeId = (int)UserTypes.Values.Client,
            //    Photo = @"C:\Users\haraissia\AndroidStudioProjects\android-topeka\app\build\intermediates\res\debug\drawable-xxxhdpi\avatar_2_raster.png",
            //    Bio = "I love good and healthy food too",
            //    CountryId = 1,
            //    RegionId = 1,
            //    CityId = 1,
            //    ZipCode = "66216",
            //    Address = "6102 Plumb Road",
            //    AddressTypeId = (int)AddressType.Values.Home,
            //    PhoneNumber = "9134060298"
            //};

            #endregion

            #endregion

            var robertSubscriptionCount = _uow.ClientSubscriptionRepository.Count(x => x.ClientId == 2);
            Assert.AreEqual(robertSubscriptionCount, 1);

            var newClientSubscription = new ClientSubscription
            {
                //ClientSubscriptionId = 1,
                ClientSubscriptionId = _uow.ClientSubscriptionRepository.All.ToList().Max(x => x.ClientSubscriptionId) + 1,
                ClientId = 2,
                CookerSubscriptionId = 2,
                Active = true,
                ValidUntil = DateTime.Today.AddMonths(1).Date,
                Recurring = false
            };
            _uow.ClientSubscriptionRepository.Add(newClientSubscription);
            _uow.Save();

            Assert.AreEqual(robertSubscriptionCount + 1, _uow.ClientSubscriptionRepository.Count(x => x.ClientId == 2));
            return newClientSubscription;
        }
        
        #endregion

        #region ChecktheSubscriptionDetail

        private void ChecktheSubscriptionDetail()
        {
            var robertNewSubscription =
                _uow.ClientSubscriptionRepository.FindBy(x => x.ClientId == 2 && x.CookerSubscriptionId == 2).FirstOrDefault();
            Debug.Assert(robertNewSubscription != null, "robertNewSubscription != null");
            Assert.AreEqual(DateTime.Today.AddMonths(1).Date, robertNewSubscription.ValidUntil);
            Assert.AreEqual(robertNewSubscription.ClientSubscriptionId, 4);
        }

        #endregion

        #region GenerateInvoiceForSubscription

        private Invoice GenerateInvoiceForSubscription(ClientSubscription newClientSubscription)
        {
            var orderSubscription = CreateSubscriptionOrder(newClientSubscription);
            _uow.OrderSubscriptionRepository.Add(orderSubscription);
            _uow.Save();
            var orderSubscriptionInvoice = CreateSubscriptionInvoice(orderSubscription);
            Assert.AreEqual(orderSubscriptionInvoice.Total, (decimal)16.21);

            return orderSubscriptionInvoice;
        }

        #region GIVEN

        private OrderSubscription CreateSubscriptionOrder(ClientSubscription newClientSubscription)
        {
            var cookerServingPriceModel = new SubscriptionHelper(_uow).GetCookerServingPriceModel(newClientSubscription.ClientSubscriptionId);
            var subscriptionOrder = new OrderSubscription
            {
                OrderSubscriptionId = _uow.OrderSubscriptionItemRepository.All.ToList().Max(x => x.OrderSubscriptionId) + 1,
                ClientId = newClientSubscription.ClientId,
                OrderDate = DateTime.Today.Date,
                DeliveryDate = null,
                OrderTypeId = (int)OrderType.Values.NotSet,
                PaymentMethodId = (int)PaymentMethodType.Values.NotSet,
                CouponId = null,
                PromotionId = null,
                PlanId = cookerServingPriceModel.PLanId,
                SubTotal = cookerServingPriceModel.Price,
                CurrencyId = (int)CurrencyType.Values.Usd,
                OrderStatusId = (int)OrderStatus.Values.InProgress,
                ServingMeasurementId = cookerServingPriceModel.ServingMeasurementId,
                NumberofServingTotal = 4 * cookerServingPriceModel.Quantity,
                ClientSubscriptionId = newClientSubscription.ClientSubscriptionId
            };

            #region WeeksSubscriptionItems

            #region Week1
            subscriptionOrder.OrderSubscriptionItems.Add(MostPopularDishFromCooker1MenuSubscriptionItem((int)WeekType.Values.Week1));
            #endregion

            #region Week2
            subscriptionOrder.OrderSubscriptionItems.Add(MostPopularDishFromCooker1MenuSubscriptionItem((int)WeekType.Values.Week2));
            #endregion

            #region Week3
            subscriptionOrder.OrderSubscriptionItems.Add(MostPopularDishFromCooker1MenuSubscriptionItem((int)WeekType.Values.Week3));

            #endregion

            #region Week4
            subscriptionOrder.OrderSubscriptionItems.Add(MostPopularDishFromCooker1MenuSubscriptionItem((int)WeekType.Values.Week4));
            #endregion

            #endregion

            return subscriptionOrder;


        }

        private OrderSubscriptionItem MostPopularDishFromCooker1MenuSubscriptionItem(int weekId)
        {
            var selectedDish = new FakeCooker1Dishes().MostPopularDish1();
            var subscriptionOrderItemDetail = new OrderSubscriptionItem
            {
                OrderSubscriptionItemId = 1,
                DishId = selectedDish.DishId,
                CookerId = selectedDish.CookerId,
                MenuId = selectedDish.MenuId,
                Quantity = 1,
                Description = selectedDish.Description,
                Instructions = "Put Extra French Fries",
                OrderSubscriptionId = _uow.OrderSubscriptionItemRepository.All.ToList().Max(x => x.OrderSubscriptionId) + 1,
                ClientOrderReviewSentClientOrderReviewSentId = new SubscriptionHelper().CreateOrderReview(selectedDish, _uow.OrderSubscriptionItemRepository.All.ToList().Max(x => x.OrderSubscriptionId) + 1).ClientOrderToReviewId,
                WeekId = weekId,
                ScheduledDate = DateTime.Today.Date,
               
            };
            return subscriptionOrderItemDetail;
        }

        #endregion

        #region Util Functions

        private Invoice CreateSubscriptionInvoice(OrderSubscription orderSubscription)
        {
            if (orderSubscription == null) return null;
            var subscriptionHelper = new SubscriptionHelper(_uow);
            var subscriptionOrderCharge = new SubscriptionCharge(uow: _uow).Calculate(orderSubscription.ClientId, orderSubscription);
            var subscriptionOrderInvoice = new Invoice
            {

                InvoiceId = _uow.InvoiceRepository.All.ToList().Max(x => x == null ? 0 : x.InvoiceId) + 1,

                #region Orders Fields
                //OrderId = null,
                OrderDate = null,
                DeliveryDate = null,
                #endregion

                #region Subscription Fields
                OrderId = orderSubscription.OrderSubscriptionId,
                SubscriptionStartDate = DateTime.Now.Date,
                SubscriptionEndDate = DateTime.Now.Date.AddMonths(1),
                SubscriptionInvoiceDate = DateTime.Now.Date,

                ClientSubscriptionId = orderSubscription.ClientSubscriptionId,
                CookerSubscriptionId = subscriptionHelper.GetCookerSubscription(orderSubscription.ClientSubscriptionId).CookerSubscriptionId,
                ServingPriceId = subscriptionHelper.GetCookerServingPriceModel(orderSubscription.ClientSubscriptionId).ServicePriceId,
                PlanId = orderSubscription.PlanId,
                PlanTitle = subscriptionHelper.GetPlanTitle(orderSubscription.PlanId),

                #endregion

                #region Common Fields

                ClientId = orderSubscription.ClientId,
                CookerId = subscriptionOrderCharge.CookerId,

                OrderModelTypeId = orderSubscription.OrderTypeId,
                OrderTypeValue = subscriptionOrderCharge.OrderTypeValue,

                PaymentMethodValue = subscriptionOrderCharge.PaymentMethodValue,
                CurrencyId = orderSubscription.CurrencyId,

                PromotionTitle = subscriptionOrderCharge.PromotionTitle,
                PromotionPrice = subscriptionOrderCharge.PromotionPrice,
                PromotionCurrencyId = subscriptionOrderCharge.PromotionCurrencyId,

                CouponTitle = subscriptionOrderCharge.CouponTitle,
                CouponPrice = subscriptionOrderCharge.CouponPrice,
                CouponCurrencyId = subscriptionOrderCharge.CouponCurrencyId,

                SalesTax = subscriptionOrderCharge.SalesTaxes,
                DeliveryFees = subscriptionOrderCharge.DeliveryFee,
                SubTotal = subscriptionOrderCharge.Subtotal,
                Total = subscriptionOrderCharge.TotalCharges

                #endregion

            };
            return subscriptionOrderInvoice;
        }
       
        #endregion

        #endregion

        #region ClientMakePayment

        private void AddInvoiceToClient(Invoice subscriptionInvoice)
        {
            var invoiceCount = _uow.InvoiceRepository.All.Count(x => x != null && x.ClientId == 2);
            Assert.AreEqual(0, invoiceCount);
            _uow.InvoiceRepository.Add(subscriptionInvoice);
            _uow.Save();
            var invoiceCountUpdated = _uow.InvoiceRepository.All.Count(x => x != null && x.ClientId == 2);
            Assert.AreEqual(1, invoiceCountUpdated);
        }

        private void ClientPaySubscriptionInvoice(Invoice subscriptionInvoice)
        {
            Debug.Assert(subscriptionInvoice.OrderId != null, "subscriptionInvoice.OrderId != null");
            var clientPaymentCount = _uow.PaymentRepository.All.Count(x => x != null && x.InvoiceId == subscriptionInvoice.InvoiceId);
            Assert.AreEqual(0, clientPaymentCount);
            var clientSubscriptionPayment = new Payment
                {
                    PaymentId = 1,
                    InvoiceId = subscriptionInvoice.InvoiceId,
                    PaymentDate = DateTime.Now.Date,
                    PaymentAmount = subscriptionInvoice.Total,
                    OrderId = (int)subscriptionInvoice.OrderId,
                    ClientId = subscriptionInvoice.ClientId,
                    CookerId = subscriptionInvoice.CookerId,
                    TransactionId = new Guid().ToString(),
                    OrderModelTypeId = (int)DAL.Fake.Model.LookUp.OrderModel.OrderModelType.Values.Transaction,
                    PaymentStatusId = (int)PaymentStatusType.Values.Pending
                    
                };
            _uow.PaymentRepository.Add(clientSubscriptionPayment);
            _uow.Save();
            var clientPaymentCountUpdate = _uow.PaymentRepository.All.Count(x => x != null && x.InvoiceId == subscriptionInvoice.InvoiceId);
            Assert.AreEqual(1, clientPaymentCountUpdate);
        }

        #endregion

        #endregion

        #region Step2

        private void CookerUpdateSubscriptionOrderstatusToIncoming(int? subscriptionOrderId)
        {
            Debug.Assert(subscriptionOrderId != null, "subscriptionOrderId != null");
            var currentSubscription = _uow.OrderSubscriptionRepository.First(x => x.OrderSubscriptionId == subscriptionOrderId);
            Assert.AreEqual((int)OrderStatus.Values.InProgress, currentSubscription.OrderStatusId);

            //Update Order Status to Incoming
            currentSubscription.OrderStatusId = (int) OrderStatus.Values.Incoming;
            Assert.AreEqual((int)OrderStatus.Values.Incoming, currentSubscription.OrderStatusId);

        }

        private void CookerUpdateSubscriptionOrderstatusToDone(int? subscriptionOrderId)
        {
            Debug.Assert(subscriptionOrderId != null, "subscriptionOrderId != null");
            var currentSubscription = _uow.OrderSubscriptionRepository.First(x => x.OrderSubscriptionId == subscriptionOrderId);
            Assert.AreEqual((int)OrderStatus.Values.Incoming, currentSubscription.OrderStatusId);

            //Update Order Status to Active
            currentSubscription.OrderStatusId = (int)OrderStatus.Values.Active;
            Assert.AreEqual((int)OrderStatus.Values.Active, currentSubscription.OrderStatusId);

            //Get The First Dish
            var subscriptionItemsForWeek1 =_uow.OrderSubscriptionItemRepository.FindBy(x => x.OrderSubscriptionId == subscriptionOrderId && x.WeekId == (int) WeekType.Values.Week1).ToList();
            
        }
        #endregion

        #region Step3
        private void ClientSubmitReviewForFirstDishInSubscriptionForWeek1(int? subscriptionOrderId)
        {
            var subscriptionItemsForWeek1 = _uow.OrderSubscriptionItemRepository.FindBy(x => x.OrderSubscriptionId == subscriptionOrderId && x.WeekId == (int)WeekType.Values.Week1).ToList();
            //Get The First Dish
            var firstDish = subscriptionItemsForWeek1.First().DishId;

        }
        #endregion

        #region Prototype
        [TestMethod]
        //public void IndexShouldListAllOwners()
        //{
        //    // Act
        //    var actual = Controller.Index();

        //    // Assert
        //    var viewResult = actual as ViewResult;
        //    if (viewResult == null) return;
        //    var data = viewResult.ViewData.Model as IList<Owner>;
        //    if (data != null) Assert.AreEqual(3, data.Count);
        //}
        #endregion

        [TestCleanup]
        public void CleanUp()
        {
            //  Controller.Dispose()
        }
    }
}
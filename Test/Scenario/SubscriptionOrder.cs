using System;
using System.Diagnostics;
using System.Linq;
using DAL.Fake.Model.GoodData.Cookers.Dishes.Cooker;
using DAL.Fake.Model.GoodData.OrderModelType;
using DAL.Fake.Model.LookUp.Currency;
using DAL.Fake.Model.LookUp.OrderStatu;
using DAL.Fake.Model.LookUp.PaymentMethod;
using DAL.Fake.Model.LookUp.PaymentStatus;
using DAL.Fake.Model.LookUp.RatingCodes;
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
    ///         Cooker Update First Subscription Item Dish ToReady
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

            CookerUpdateFirstSubscriptionItemDishToReady(subscriptionInvoice.OrderId);
            ClientSubmitReviewForFirstDishInSubscriptionForWeek1(subscriptionInvoice.OrderId);


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
                OrderStatusId = (int)OrderStatus.Values.Scheduled
               
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
        }
        #endregion

        #region Step3

        private void CookerUpdateFirstSubscriptionItemDishToReady(int? subscriptionOrderId)
        {
            var firstsubscriptionItemForWeek1 = _uow.OrderSubscriptionItemRepository.FindBy(x => x.OrderSubscriptionId == subscriptionOrderId && x.WeekId == (int)WeekType.Values.Week1).First();
            Assert.AreEqual((int)OrderStatus.Values.Scheduled, firstsubscriptionItemForWeek1.OrderStatusId);
            Assert.AreEqual(1, firstsubscriptionItemForWeek1.DishId);
        }

        private void ClientSubmitReviewForFirstDishInSubscriptionForWeek1(int? subscriptionOrderId)
        {
            var firstsubscriptionItemForWeek1 = _uow.OrderSubscriptionItemRepository.FindBy(x => x.OrderSubscriptionId == subscriptionOrderId && x.WeekId == (int)WeekType.Values.Week1).First();
         
            // Client Order to Review
            var clientOrderToReview = new ClientOrderToReview
            {
                ClientOrderToReviewId =  _uow.ClientOrderToReviewRepository.All.ToList().Max(x => x.ClientOrderToReviewId) + 1,
                ClientId = 2,
                CookerId = firstsubscriptionItemForWeek1.CookerId,
                MenuId = firstsubscriptionItemForWeek1.MenuId,
                OrderId = firstsubscriptionItemForWeek1.OrderSubscriptionId,
                OverallFeedBackRating = 0,
                ItemAccuracyRating = 0,
                CommunicationRating = 0,
                DeliveryTimeRating = 0,
                Comment = null,
                Photo = null,
                OrderDate = DateTime.Today.Date,
                OrderModelTypeId = (int)DAL.Fake.Model.LookUp.OrderModel.OrderModelType.Values.Subscription
            };
            _uow.ClientOrderToReviewRepository.Add(clientOrderToReview);
            _uow.Save();

            //Client Review Order
             var clientOrderReviewSent = new ClientOrderReviewSent
            {
                ClientOrderReviewSentId =  _uow.ClientOrderReviewSentRepository.All.ToList().Max(x => x.ClientOrderReviewSentId) + 1,
                ClientId = 2,
                CookerId = firstsubscriptionItemForWeek1.CookerId,
                MenuId = firstsubscriptionItemForWeek1.MenuId,
                OrderId = firstsubscriptionItemForWeek1.OrderSubscriptionId,
                OverallFeedBackRating = (int)RatingCodeType.Values.Positive,
                ItemAccuracyRating = 4,
                CommunicationRating = 3,
                DeliveryTimeRating = 2,
                Comment = null,
                Photo = null,
                OrderDate = DateTime.Today.Date,
                OrderModelTypeId = (int)DAL.Fake.Model.LookUp.OrderModel.OrderModelType.Values.Subscription
            };
            _uow.ClientOrderReviewSentRepository.Add(clientOrderReviewSent);
            _uow.Save();
            

            //Cooker Review Received
            var cookerOrderReviewReceived = new CookerOrderReviewReceived
            {
                CookerOrderReviewReceivedId = _uow.CookerOrderReviewReceivedRepository.All.ToList().Max(x => x.CookerOrderReviewReceivedId) + 1,
                CookerId = 1,
                ClientId = 1,
                MenuId = 1,
                OrderId = 1,
                OverallFeedBackRating = (int)RatingCodeType.Values.Positive,
                ItemAccuracyRating = 4,
                CommunicationRating = 3,
                DeliveryTimeRating = 2,
                Comment = null,
                Photo = null,
                OrderDate = DateTime.Today.Date,
            };
            _uow.CookerOrderReviewReceivedRepository.Add(cookerOrderReviewReceived);
            _uow.Save();


            //Delete Client Order to Review 
            _uow.ClientOrderToReviewRepository.Delete(clientOrderToReview);


            //Update CookerFeedback
            var cookerFeedback = _uow.CookerFeedBackRepository.FindBy(x => x.CookerId == 1).FirstOrDefault();
            Debug.Assert(cookerFeedback != null, "cookerFeedback != null");
            cookerFeedback.TransactionsCount += 1;
            cookerFeedback.ReviewScore = cookerFeedback.ReviewScore + cookerOrderReviewReceived.ItemAccuracyRating +
                                         cookerOrderReviewReceived.CommunicationRating +
                                         cookerOrderReviewReceived.DeliveryTimeRating;

            if (cookerOrderReviewReceived.OverallFeedBackRating == (int) RatingCodeType.Values.Positive)
            {
                cookerFeedback.ReviewScore = cookerFeedback.ReviewScore + (int)RatingCodeType.Values.Positive;
            }


            //Update CookerReviewScore
            var cookerReviewScore = _uow.CookerReviewScoreRepository.FindBy(x => x.CookerId == 1).FirstOrDefault();
            Debug.Assert(cookerReviewScore != null, "cookerReviewScore != null");
            if (cookerOrderReviewReceived.OverallFeedBackRating == (int)RatingCodeType.Values.Positive)
            {
                cookerReviewScore.PositiveReview = cookerReviewScore.PositiveReview + 1;
            }
            if (cookerOrderReviewReceived.OverallFeedBackRating == (int)RatingCodeType.Values.Negative)
            {
                cookerReviewScore.NegativeReview = cookerReviewScore.NegativeReview + 1;
            }
            if (cookerOrderReviewReceived.OverallFeedBackRating == (int)RatingCodeType.Values.Neutral)
            {
                cookerReviewScore.NeutralReview = cookerReviewScore.NeutralReview + 1;
            }

            //UpdateCookerServiceDetail
            var cookerReviewServiceDetail = _uow.CookerReviewServiceDetailRepository.FindBy(x => x.CookerId == 1).FirstOrDefault();
            Debug.Assert(cookerReviewServiceDetail != null, "CookerReviewServiceDetail != null");
            cookerReviewServiceDetail.ItemAccuracyRating = (cookerReviewServiceDetail.ItemAccuracyRating * cookerReviewServiceDetail.NumberofRatings + cookerOrderReviewReceived.ItemAccuracyRating)/(cookerReviewServiceDetail.NumberofRatings + 1);
            cookerReviewServiceDetail.CommunicationRating = (cookerReviewServiceDetail.CommunicationRating * cookerReviewServiceDetail.NumberofRatings + cookerOrderReviewReceived.CommunicationRating) / (cookerReviewServiceDetail.CommunicationRating + 1);
            cookerReviewServiceDetail.ItemAccuracyRating = (cookerReviewServiceDetail.DeliveryTimeRating * cookerReviewServiceDetail.NumberofRatings + cookerOrderReviewReceived.DeliveryTimeRating) / (cookerReviewServiceDetail.NumberofRatings + 1);
            cookerReviewServiceDetail.OverallFeedBackRating = (cookerReviewServiceDetail.OverallFeedBackRating * cookerReviewServiceDetail.NumberofRatings + cookerOrderReviewReceived.OverallFeedBackRating) / (cookerReviewServiceDetail.NumberofRatings + 1);
            cookerReviewServiceDetail.NumberofRatings += 1;

        }




        private void CookerSubmitReviewForFirstDishInSubscriptionForWeek1(int? subscriptionOrderId)
        {
            var firstsubscriptionItemForWeek1 = _uow.OrderSubscriptionItemRepository.FindBy(x => x.OrderSubscriptionId == subscriptionOrderId && x.WeekId == (int)WeekType.Values.Week1).First();

            // Cooker Order to Review
            var cookerOrderToReview = new CookerOrderToReview
            {
                CookerOrderToReviewId = _uow.CookerOrderToReviewRepository.All.ToList().Max(x => x.CookerOrderToReviewId) + 1,
                ClientId = 2,
                CookerId = firstsubscriptionItemForWeek1.CookerId,
                MenuId = firstsubscriptionItemForWeek1.MenuId,
                OrderId = firstsubscriptionItemForWeek1.OrderSubscriptionId,
                OverallFeedBackRating = 0,
                ItemAccuracyRating = 0,
                CommunicationRating = 0,
                DeliveryTimeRating = 0,
                Comment = null,
                Photo = null,
                OrderDate = DateTime.Today.Date,
                OrderModelTypeId = (int)DAL.Fake.Model.LookUp.OrderModel.OrderModelType.Values.Subscription
            };
            _uow.CookerOrderToReviewRepository.Add(cookerOrderToReview);
            _uow.Save();

            //Cooker Review Order
            var cookerOrderReviewSent = new CookerOrderReviewSent
            {
                CookerOrderReviewSentId = _uow.CookerOrderReviewSentRepository.All.ToList().Max(x => x.CookerOrderReviewSentId) + 1,
                ClientId = 2,
                CookerId = firstsubscriptionItemForWeek1.CookerId,
                MenuId = firstsubscriptionItemForWeek1.MenuId,
                OrderId = firstsubscriptionItemForWeek1.OrderSubscriptionId,
                OverallFeedBackRating = (int)RatingCodeType.Values.Positive,
                ItemAccuracyRating = 4,
                CommunicationRating = 3,
                DeliveryTimeRating = 2,
                Comment = null,
                Photo = null,
                OrderDate = DateTime.Today.Date,
                OrderModelTypeId = (int)DAL.Fake.Model.LookUp.OrderModel.OrderModelType.Values.Subscription
            };
            _uow.CookerOrderReviewSentRepository.Add(cookerOrderReviewSent);
            _uow.Save();


            //Client Review Received
            var clientOrderReviewReceived = new ClientOrderReviewReceived
            {
                ClientOrderReviewReceivedId = _uow.ClientOrderReviewReceivedRepository.All.ToList().Max(x => x.ClientOrderReviewReceivedId) + 1,
                CookerId = 1,
                ClientId = 1,
                MenuId = 1,
                OrderId = 1,
                OverallFeedBackRating = (int)RatingCodeType.Values.Positive,
                ItemAccuracyRating = 4,
                CommunicationRating = 3,
                DeliveryTimeRating = 2,
                Comment = null,
                Photo = null,
                OrderDate = DateTime.Today.Date,
            };
            _uow.ClientOrderReviewReceivedRepository.Add(clientOrderReviewReceived);
            _uow.Save();


            //Delete Cooker Order to Review 
            _uow.CookerOrderToReviewRepository.Delete(cookerOrderToReview);


            //Update ClientFeedback
            var clientFeedback = _uow.ClientFeedBackRepository.FindBy(x => x.ClientId == 1).FirstOrDefault();
            Debug.Assert(clientFeedback != null, "clientFeedback != null");
            clientFeedback.TransactionsCount += 1;
            clientFeedback.ReviewScore = clientFeedback.ReviewScore + clientOrderReviewReceived.ItemAccuracyRating +
                                         clientOrderReviewReceived.CommunicationRating +
                                         clientOrderReviewReceived.DeliveryTimeRating;

            if (clientOrderReviewReceived.OverallFeedBackRating == (int)RatingCodeType.Values.Positive)
            {
                clientFeedback.ReviewScore = clientFeedback.ReviewScore + (int)RatingCodeType.Values.Positive;
            }


            //Update ClientReviewScore
            var clientReviewScore = _uow.ClientReviewScoreRepository.FindBy(x => x.ClientId == 1).FirstOrDefault();
            Debug.Assert(clientReviewScore != null, "clientReviewScore != null");
            if (clientOrderReviewReceived.OverallFeedBackRating == (int)RatingCodeType.Values.Positive)
            {
                clientReviewScore.PositiveReview = clientReviewScore.PositiveReview + 1;
            }
            if (clientOrderReviewReceived.OverallFeedBackRating == (int)RatingCodeType.Values.Negative)
            {
                clientReviewScore.NegativeReview = clientReviewScore.NegativeReview + 1;
            }
            if (clientOrderReviewReceived.OverallFeedBackRating == (int)RatingCodeType.Values.Neutral)
            {
                clientReviewScore.NeutralReview = clientReviewScore.NeutralReview + 1;
            }

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
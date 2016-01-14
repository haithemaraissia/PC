using System;
using System.Diagnostics;
using System.Linq;
using DAL.Fake.Model.GoodData.Cookers.Dishes.Cooker;
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
using OrderModelType = DAL.Fake.Model.LookUp.OrderModel.OrderModelType;
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
    ///         Client submit and receive a review for the first dish in the subscription for week 1
    ///         Cooker Submit and receive a review for the first dish in the subscription for week 1
    ///         Cooker and Client reviews is calculated for subscriptions based on dish1 of week1 
    /// </summary>


    [TestClass]
    public class SubscriptionOrder
    {
        private UnitofWork _uow;


        [TestInitialize]
        public void Initialize()
        {
            _uow = new UnitofWorkHelper().GetAllRepository();
        }


        [TestMethod]
        public void Steps()
        {
            #region STEP1
            var newClientSubscription = ClientSubscribeToCookerSubscription();
            ChecktheSubscriptionDetail();
            var subscriptionInvoice = GenerateInvoiceForSubscription(newClientSubscription);
            AddInvoiceToClient(subscriptionInvoice);
            ClientPaySubscriptionInvoice(subscriptionInvoice);
            #endregion

            #region STEP2
            CookerUpdateSubscriptionOrderstatusToIncoming(subscriptionInvoice.OrderId);
            CookerUpdateSubscriptionOrderstatusToDone(subscriptionInvoice.OrderId);
            #endregion

            #region STEP3
            CookerUpdateFirstSubscriptionItemDishToReady(subscriptionInvoice.OrderId);
            ClientReviewForFirstDishInSubscriptionForWeek1(subscriptionInvoice.OrderId);
            CookerReviewForFirstDishInSubscriptionForWeek1(subscriptionInvoice.OrderId);
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

            _uow.OrderSubscriptionRepository.Add(subscriptionOrder);
            _uow.Save();
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
                    OrderModelTypeId = (int)OrderModelType.Values.Transaction,
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
            currentSubscription.OrderStatusId = (int)OrderStatus.Values.Incoming;
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
            var firstsubscriptionItemForWeek1 = FirstsubscriptionItemForWeek1(subscriptionOrderId);
            Assert.AreEqual((int)OrderStatus.Values.Scheduled, firstsubscriptionItemForWeek1.OrderStatusId);
            Assert.AreEqual(1, firstsubscriptionItemForWeek1.DishId);
            firstsubscriptionItemForWeek1.OrderStatusId = (int)OrderStatus.Values.Ready;
            _uow.Save();
            Assert.AreEqual((int)OrderStatus.Values.Ready, firstsubscriptionItemForWeek1.OrderStatusId);
        }

        private OrderSubscriptionItem FirstsubscriptionItemForWeek1(int? subscriptionOrderId)
        {
            Debug.Assert(_uow.OrderSubscriptionRepository != null, "_uow.OrderSubscriptionRepository != null");
            var subscriptionsOrderItems =
                _uow.OrderSubscriptionRepository.FirstOrDefault(x => x.OrderSubscriptionId == subscriptionOrderId)
                    .OrderSubscriptionItems;

            var firstsubscriptionItemForWeek1 = subscriptionsOrderItems.First(x => x.WeekId == (int)WeekType.Values.Week1);
            return firstsubscriptionItemForWeek1;
        }

        private void ClientReviewForFirstDishInSubscriptionForWeek1(int? subscriptionOrderId)
        {
            var firstsubscriptionItemForWeek1 = FirstsubscriptionItemForWeek1(subscriptionOrderId);

            var clientOrderToReview = CreateClientOrdertoReview(firstsubscriptionItemForWeek1);
            CreateClientOrderReviewSentToCooker(firstsubscriptionItemForWeek1);
            var cookerOrderReviewReceived = CookerOrderReviewReceived(firstsubscriptionItemForWeek1);
            DeleteClientOrderToReview(clientOrderToReview);

            UpdateCookerFeedBack_And_ReviewScore_And_ServiceDetail(cookerOrderReviewReceived);
        }

        private void CookerReviewForFirstDishInSubscriptionForWeek1(int? subscriptionOrderId)
        {
            var firstsubscriptionItemForWeek1 = FirstsubscriptionItemForWeek1(subscriptionOrderId);
            var cookerOrderToReview = CreateCookerOrderToReview(firstsubscriptionItemForWeek1);
            CreateCookerOrderReviewSentToClient(firstsubscriptionItemForWeek1);
            var clientOrderReviewReceived = ClientOrderReviewReceived(firstsubscriptionItemForWeek1);
            DeleteCookerOrderToReview(cookerOrderToReview);

            UpdateClientFeedBack_And_ReviewScore(clientOrderReviewReceived);
        }

        #region Client Review

        private ClientOrderToReview CreateClientOrdertoReview(OrderSubscriptionItem firstsubscriptionItemForWeek1)
        {
            Assert.AreEqual(0, _uow.ClientOrderToReviewRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
            // Client Order to Review
            var clientOrderToReview = new ClientOrderToReview
            {
                ClientOrderToReviewId = _uow.ClientOrderToReviewRepository.All.ToList().Max(x => x.ClientOrderToReviewId) + 1,
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
                OrderModelTypeId = (int)OrderModelType.Values.Subscription
            };
            _uow.ClientOrderToReviewRepository.Add(clientOrderToReview);
            _uow.Save();
            Assert.AreEqual(1, _uow.ClientOrderToReviewRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
            return clientOrderToReview;
        }

        private void CreateClientOrderReviewSentToCooker(OrderSubscriptionItem firstsubscriptionItemForWeek1)
        {
            Assert.AreEqual(0, _uow.ClientOrderReviewSentRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
            var clientOrderReviewSent = new ClientOrderReviewSent
            {
                ClientOrderReviewSentId =
                    _uow.ClientOrderReviewSentRepository.All.ToList().Max(x => x.ClientOrderReviewSentId) + 1,
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
                OrderModelTypeId = (int)OrderModelType.Values.Subscription
            };
            _uow.ClientOrderReviewSentRepository.Add(clientOrderReviewSent);
            _uow.Save();
            Assert.AreEqual(1, _uow.ClientOrderReviewSentRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
        }

        private CookerOrderReviewReceived CookerOrderReviewReceived(OrderSubscriptionItem firstsubscriptionItemForWeek1)
        {
            Assert.AreEqual(0, _uow.CookerOrderReviewReceivedRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
            //Cooker Review Received
            var cookerOrderReviewReceived = new CookerOrderReviewReceived
            {
                CookerOrderReviewReceivedId =
                    _uow.CookerOrderReviewReceivedRepository.All.ToList().Max(x => x.CookerOrderReviewReceivedId) + 1,
                CookerId = firstsubscriptionItemForWeek1.CookerId,
                ClientId = 1,
                MenuId = firstsubscriptionItemForWeek1.MenuId,
                OrderId = firstsubscriptionItemForWeek1.OrderSubscriptionId,
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
            Assert.AreEqual(1, _uow.CookerOrderReviewReceivedRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
            return cookerOrderReviewReceived;
        }

        private void DeleteClientOrderToReview(ClientOrderToReview clientOrderToReview)
        {
            //Delete Client Order to Review 
            Assert.AreEqual(1, _uow.ClientOrderToReviewRepository.FindBy(x => x.ClientOrderToReviewId == clientOrderToReview.ClientOrderToReviewId).Count());
            _uow.ClientOrderToReviewRepository.Delete(clientOrderToReview);
            _uow.Save();
            Assert.AreEqual(0, _uow.ClientOrderToReviewRepository.FindBy(x => x.ClientOrderToReviewId == clientOrderToReview.ClientOrderToReviewId).Count());
        }

        private void UpdateCookerFeedBack_And_ReviewScore_And_ServiceDetail(CookerOrderReviewReceived cookerOrderReviewReceived)
        {
            #region UpdateCookerFeedback

            //Update CookerFeedback
            var cookerFeedback = _uow.CookerFeedBackRepository.FindBy(x => x.CookerId == 1).FirstOrDefault();
            Debug.Assert(cookerFeedback != null, "cookerFeedback != null");

            Assert.AreEqual(2, cookerFeedback.TransactionsCount);
            Assert.AreEqual(5, cookerFeedback.ReviewScore);
            Assert.AreEqual((decimal)0.5, cookerFeedback.PositiveReview);

            cookerFeedback.TransactionsCount += 1;
            cookerFeedback.ReviewScore = cookerFeedback.ReviewScore + cookerOrderReviewReceived.ItemAccuracyRating +
                                         cookerOrderReviewReceived.CommunicationRating +
                                         cookerOrderReviewReceived.DeliveryTimeRating;

            if (cookerOrderReviewReceived.OverallFeedBackRating == (int)RatingCodeType.Values.Positive)
            {
                cookerFeedback.PositiveReview = cookerFeedback.PositiveReview + (int)RatingCodeType.Values.Positive;
            }

            Assert.AreEqual(3, cookerFeedback.TransactionsCount);
            Assert.AreEqual(14, cookerFeedback.ReviewScore);
            Assert.AreEqual((decimal)1.5, cookerFeedback.PositiveReview);

            #endregion

            #region UpdateCookerReviewScore
            //Update CookerReviewScore
            var cookerReviewScore = _uow.CookerReviewScoreRepository.FindBy(x => x.CookerId == 1).FirstOrDefault();
            Debug.Assert(cookerReviewScore != null, "cookerReviewScore != null");

            Assert.AreEqual(1, cookerReviewScore.PositiveReview);
            Assert.AreEqual(0, cookerReviewScore.NegativeReview);
            Assert.AreEqual(0, cookerReviewScore.NeutralReview);

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

            Assert.AreEqual(2, cookerReviewScore.PositiveReview);
            Assert.AreEqual(0, cookerReviewScore.NegativeReview);
            Assert.AreEqual(0, cookerReviewScore.NeutralReview);

            #endregion

            #region UpdateCookerServiceDetail
            //UpdateCookerServiceDetail

            var cookerReviewServiceDetail =
                _uow.CookerReviewServiceDetailRepository.FindBy(x => x.CookerId == 1).FirstOrDefault();
            Debug.Assert(cookerReviewServiceDetail != null, "CookerReviewServiceDetail != null");

            Assert.AreEqual(1, cookerReviewServiceDetail.ItemAccuracyRating);
            Assert.AreEqual(4, cookerReviewServiceDetail.CommunicationRating);
            Assert.AreEqual(1, cookerReviewServiceDetail.ItemAccuracyRating);
            Assert.AreEqual(2, cookerReviewServiceDetail.OverallFeedBackRating);
            Assert.AreEqual(7, cookerReviewServiceDetail.NumberofRatings);

            cookerReviewServiceDetail.ItemAccuracyRating = (cookerReviewServiceDetail.ItemAccuracyRating *
                                                            cookerReviewServiceDetail.NumberofRatings +
                                                            cookerOrderReviewReceived.ItemAccuracyRating) /
                                                           (cookerReviewServiceDetail.NumberofRatings + 1);
            cookerReviewServiceDetail.CommunicationRating = (cookerReviewServiceDetail.CommunicationRating *
                                                             cookerReviewServiceDetail.NumberofRatings +
                                                             cookerOrderReviewReceived.CommunicationRating) /
                                                            (cookerReviewServiceDetail.CommunicationRating + 1);
            cookerReviewServiceDetail.ItemAccuracyRating = (cookerReviewServiceDetail.DeliveryTimeRating *
                                                            cookerReviewServiceDetail.NumberofRatings +
                                                            cookerOrderReviewReceived.DeliveryTimeRating) /
                                                           (cookerReviewServiceDetail.NumberofRatings + 1);
            cookerReviewServiceDetail.OverallFeedBackRating = (cookerReviewServiceDetail.OverallFeedBackRating *
                                                               cookerReviewServiceDetail.NumberofRatings +
                                                               cookerOrderReviewReceived.OverallFeedBackRating) /
                                                              (cookerReviewServiceDetail.NumberofRatings + 1);
            cookerReviewServiceDetail.NumberofRatings += 1;

            Assert.AreEqual(4, cookerReviewServiceDetail.ItemAccuracyRating);
            Assert.AreEqual(6, cookerReviewServiceDetail.CommunicationRating);
            Assert.AreEqual(4, cookerReviewServiceDetail.ItemAccuracyRating);
            Assert.AreEqual(1, cookerReviewServiceDetail.OverallFeedBackRating);
            Assert.AreEqual(8, cookerReviewServiceDetail.NumberofRatings);

            #endregion

        }

        #endregion

        #region Cooker Review

        private CookerOrderToReview CreateCookerOrderToReview(OrderSubscriptionItem firstsubscriptionItemForWeek1)
        {
            Assert.AreEqual(0, _uow.CookerOrderToReviewRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
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
                OrderModelTypeId = (int)OrderModelType.Values.Subscription
            };
            _uow.CookerOrderToReviewRepository.Add(cookerOrderToReview);
            _uow.Save();
            Assert.AreEqual(1, _uow.CookerOrderToReviewRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
            return cookerOrderToReview;
        }

        private void CreateCookerOrderReviewSentToClient(OrderSubscriptionItem firstsubscriptionItemForWeek1)
        {
            Assert.AreEqual(0, _uow.CookerOrderReviewSentRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
            //Cooker Review Order
            var cookerOrderReviewSent = new CookerOrderReviewSent
            {
                CookerOrderReviewSentId =
                    _uow.CookerOrderReviewSentRepository.All.ToList().Max(x => x.CookerOrderReviewSentId) + 1,
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
                OrderModelTypeId = (int)OrderModelType.Values.Subscription
            };
            _uow.CookerOrderReviewSentRepository.Add(cookerOrderReviewSent);
            _uow.Save();
            Assert.AreEqual(1, _uow.CookerOrderReviewSentRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
        }

        private ClientOrderReviewReceived ClientOrderReviewReceived(OrderSubscriptionItem firstsubscriptionItemForWeek1)
        {
            Assert.AreEqual(0, _uow.ClientOrderReviewReceivedRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
            var clientOrderReviewReceived = new ClientOrderReviewReceived
            {
                ClientOrderReviewReceivedId = _uow.ClientOrderReviewReceivedRepository.All.ToList().Max(x => x.ClientOrderReviewReceivedId) + 1,
                CookerId = firstsubscriptionItemForWeek1.CookerId,
                ClientId = 2,
                MenuId = firstsubscriptionItemForWeek1.MenuId,
                OrderId = firstsubscriptionItemForWeek1.OrderSubscriptionId,
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
            Assert.AreEqual(1, _uow.ClientOrderReviewReceivedRepository.FindBy(x => x.OrderId == firstsubscriptionItemForWeek1.OrderSubscriptionId).Count());
            return clientOrderReviewReceived;
        }

        private void DeleteCookerOrderToReview(CookerOrderToReview cookerOrderToReview)
        {
            Assert.AreEqual(1, _uow.CookerOrderToReviewRepository.FindBy(x => x.CookerOrderToReviewId == cookerOrderToReview.CookerOrderToReviewId).Count());
            _uow.CookerOrderToReviewRepository.Delete(cookerOrderToReview);
            _uow.Save();
            Assert.AreEqual(0, _uow.CookerOrderToReviewRepository.FindBy(x => x.CookerOrderToReviewId == cookerOrderToReview.CookerOrderToReviewId).Count());
        }

        private void UpdateClientFeedBack_And_ReviewScore(ClientOrderReviewReceived clientOrderReviewReceived)
        {
            #region UpdateClientFeedBack
            //Update ClientFeedback
            var clientFeedback = _uow.ClientFeedBackRepository.FindBy(x => x.ClientId == 1).FirstOrDefault();
            Debug.Assert(clientFeedback != null, "clientFeedback != null");

            Assert.AreEqual(1, clientFeedback.TransactionsCount);
            Assert.AreEqual(3, clientFeedback.ReviewScore);
            Assert.AreEqual((decimal)0.2, clientFeedback.PositiveReview);

            clientFeedback.TransactionsCount += 1;
            clientFeedback.ReviewScore = clientFeedback.ReviewScore + clientOrderReviewReceived.ItemAccuracyRating +
                                         clientOrderReviewReceived.CommunicationRating +
                                         clientOrderReviewReceived.DeliveryTimeRating;

            if (clientOrderReviewReceived.OverallFeedBackRating == (int)RatingCodeType.Values.Positive)
            {
                clientFeedback.PositiveReview = clientFeedback.PositiveReview + (int)RatingCodeType.Values.Positive;
            }
            Assert.AreEqual(2, clientFeedback.TransactionsCount);
            Assert.AreEqual(12, clientFeedback.ReviewScore);
            Assert.AreEqual((decimal)1.2, clientFeedback.PositiveReview);

            #endregion

            #region UpdateClientReviewScore
            //Update ClientReviewScore
            var clientReviewScore = _uow.ClientReviewScoreRepository.FindBy(x => x.ClientId == 1).FirstOrDefault();
            Debug.Assert(clientReviewScore != null, "clientReviewScore != null");

            Assert.AreEqual(1, clientReviewScore.PositiveReview);
            Assert.AreEqual(0, clientReviewScore.NegativeReview);
            Assert.AreEqual(0, clientReviewScore.NeutralReview);

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

            Assert.AreEqual(2, clientReviewScore.PositiveReview);
            Assert.AreEqual(0, clientReviewScore.NegativeReview);
            Assert.AreEqual(0, clientReviewScore.NeutralReview);

            #endregion
        }

        #endregion

        #endregion

        [TestCleanup]
        public void CleanUp()
        {
        }
    }
}
using System;
using System.Diagnostics;
using System.Linq;
using DAL.Fake.Model.LookUp.Currency;
using DAL.Fake.Model.LookUp.DishOption;
using DAL.Fake.Model.LookUp.OrderStatu;
using DAL.Fake.Model.LookUp.PaymentMethod;
using DAL.Fake.Model.LookUp.PaymentStatus;
using DAL.Fake.Model.LookUp.RatingCodes;
using DAL.Fake.Model.Util.Orders;
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
    ///         Client make a transaction order
    ///         An Invoice is genereated
    ///         A payment is made

    ///     STEP 2
    ///         Cooker recieve an Order
    ///         Change its status to done

    ///     STEP 3
    ///         Client submit review
    ///         Cooker Submit review
    ///         Client/Cooker review is calculated
    /// </summary>


    [TestClass]
    public class TransactionOrder
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
            var clientNewOrderTransaction = ClientOrderTransaction();
            ChecktheOrderTransactionDetail(clientNewOrderTransaction);
            var orderInvoice = GenerateInvoiceForOrder(clientNewOrderTransaction);
            AddInvoiceToClient(orderInvoice);
            ClientPayOrderInvoice(orderInvoice);
            #endregion

            #region STEP2
            CookerUpdateTransactionOrderstatusToIncoming(orderInvoice.OrderId);
            CookerUpdateTransactionOrderstatusToDone(orderInvoice.OrderId);
            #endregion

            #region STEP3
            CookerUpdateOrderToReady(orderInvoice.OrderId);
            ClientReviewOrder(clientNewOrderTransaction.OrderItems.First());
            CookerReviewOrder(clientNewOrderTransaction.OrderItems.First());
            #endregion

        }


        #region Step1

        #region ClientOrderTransaction

        private Order ClientOrderTransaction()
        {
            var orderCount = _uow.OrderRepository.FindBy(x => x.OrderTypeId == (int)OrderModelType.Values.Transaction && x.ClientId == 2).Count();
            Assert.AreEqual(orderCount, 0);
            var newOrder =  CreateOrder();
            _uow.OrderRepository.Add(newOrder);
            _uow.Save();
            return newOrder;
        }

        #endregion

        #region ChecktheOrderTransactionDetail

        private void ChecktheOrderTransactionDetail(Order order)
        {
            var orderCount = _uow.OrderRepository.FindBy(x => x.OrderTypeId == (int)OrderModelType.Values.Transaction && x.ClientId == 2).Count();
            Assert.AreEqual(orderCount, 1);
            Assert.AreEqual(order.OrderItems.First().DishId, 4);
            Assert.AreEqual(order.OrderItems.First().Quantity, 2);
            Assert.AreEqual(order.OrderItems.First().OrderItemDishOptions.First().Price, (decimal?)0.53);
        }

        #endregion

        #region GenerateInvoiceForOrder

        private Invoice GenerateInvoiceForOrder(Order clientNewOrderTransaction)
        {
            var orderInvoice = CreateOrderInvoice(clientNewOrderTransaction);
            Assert.AreEqual(orderInvoice.Total, (decimal)22.78);
            return orderInvoice;
        }

        #region Util Functions

        private Invoice CreateOrderInvoice(Order clientNewOrderTransaction)
        {
            if (clientNewOrderTransaction == null) return null;

            var orderCharge = new OrderCharge(uow: _uow).Calculate(clientNewOrderTransaction);

            var orderInvoice = new Invoice
            {
                InvoiceId = _uow.InvoiceRepository.All.ToList().Max(x => x == null ? 0 : x.InvoiceId) + 1,

                OrderId = clientNewOrderTransaction.OrderId,
                ClientId = clientNewOrderTransaction.ClientId,
                OrderDate = clientNewOrderTransaction.OrderDate,
                DeliveryDate = clientNewOrderTransaction.DeliveryDate,
                CurrencyId = clientNewOrderTransaction.CurrencyId,

                CookerId = orderCharge.CookerId,
                OrderTypeValue = orderCharge.OrderTypeValue,
                PaymentMethodValue = orderCharge.PaymentMethodValue,

                PromotionTitle = orderCharge.PromotionTitle,
                PromotionPrice = orderCharge.PromotionPrice,
                PromotionCurrencyId = orderCharge.PromotionCurrencyId,

                CouponTitle = orderCharge.CouponTitle,
                CouponPrice = orderCharge.CouponPrice,
                CouponCurrencyId = orderCharge.CouponCurrencyId,

                PlanTitle = orderCharge.PlanTitle,
                SalesTax = orderCharge.SalesTaxes,
                DeliveryFees = orderCharge.DeliveryFee,
                SubTotal = orderCharge.Subtotal,
                Total = orderCharge.TotalCharges,

                OrderModelTypeId = (int)OrderModelType.Values.Transaction,
                CookerSubscriptionId = null,
                ServingPriceId = null,
                PlanId = null

            };
            return orderInvoice;
        }
        
        #endregion
       
        #endregion

        #region ClientMakePayment

        private void AddInvoiceToClient(Invoice orderInvoice)
        {
            var invoiceCount = _uow.InvoiceRepository.All.Count(x => x != null && x.ClientId == 2);
            Assert.AreEqual(0, invoiceCount);
            _uow.InvoiceRepository.Add(orderInvoice);
            _uow.Save();
            var invoiceCountUpdated = _uow.InvoiceRepository.All.Count(x => x != null && x.ClientId == 2);
            Assert.AreEqual(1, invoiceCountUpdated);
        }

        private void ClientPayOrderInvoice(Invoice orderInvoice)
        {
            Debug.Assert(orderInvoice.OrderId != null, "orderInvoice.OrderId != null");
            var clientPaymentCount = _uow.PaymentRepository.All.Count(x => x != null && x.InvoiceId == orderInvoice.InvoiceId);
            Assert.AreEqual(0, clientPaymentCount);
            var clientSubscriptionPayment = new Payment
            {
                PaymentId = _uow.PaymentRepository.All.ToList().Max(x => x == null ? 0 : x.PaymentId) + 1,
                InvoiceId = orderInvoice.InvoiceId,
                PaymentDate = DateTime.Now.Date,
                PaymentAmount = orderInvoice.Total,
                OrderId = (int)orderInvoice.OrderId,
                ClientId = orderInvoice.ClientId,
                CookerId = orderInvoice.CookerId,
                TransactionId = new Guid().ToString(),
                OrderModelTypeId = (int)OrderModelType.Values.Transaction,
                PaymentStatusId = (int)PaymentStatusType.Values.Pending

            };
            _uow.PaymentRepository.Add(clientSubscriptionPayment);
            _uow.Save();
            var clientPaymentCountUpdate = _uow.PaymentRepository.All.Count(x => x != null && x.InvoiceId == orderInvoice.InvoiceId);
            Assert.AreEqual(1, clientPaymentCountUpdate);
        }

        #endregion
   
        #region GIVEN

        #region Client / Cooker Information

        #region Client Information

        //var firstCooker = new Cooker
        //{
        //    CookerId = 1,
        //    UserId = 1,
        //    RestaurantName = " Fiorella's Express",
        //    RestaurantPhoto = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\Test\Images\Restaurant\FiorellaExpress.jpg",
        //    Cuisines = LookUp.Cuisine.Cuisines.Types.Italian + " ," + LookUp.Cuisine.Cuisines.Types.Mexican,
        //    PhoneNumber = "913-524-2544",
        //    Bio = "At Big Al`s their reputation has been built on providing great service ranging from small lunches to large corporate catered meetings and events.",
        //    Rating = 5,
        //    TotalRaters = 12,
        //    OfferDelivery = true,
        //    OfferPickUp = true,
        //    TaxPercent = (decimal?)8.15,
        //    AmountforFreeDelivery = (decimal?)50.00,
        //    WaitingTime = 15,
        //    NumberofSubscription = 1
        //};

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

        #region Order

        //Pick Up
        //Client 2
        // Cooker 1
        //Dish 4 ( 10.00) * 2
        //OrderItemDishOptionId 3,  ( 0.53)  * 2

        private Order CreateOrder()
        {
            var order = new Order
            {
                OrderId = _uow.OrderRepository.All.ToList().Max(x => x.OrderId) + 1,
                ClientId = 2,
                OrderDate = DateTime.Today.Date,
                DeliveryDate = null,
                OrderTypeId = (int)OrderType.Values.PickUp,
                PaymentMethodId = (int)PaymentMethodType.Values.CardOnLine,
                CouponId = null,
                PromotionId = null,
                PlanId = null,
                CurrencyId = (int)CurrencyType.Values.Usd,
                SubTotal = (decimal)21.06,
                OrderStatusId = (int)OrderStatus.Values.Submitted
            };
            order.OrderItems.Add(GetOrderItem());
            return order;
        }

        #region OrderItems

        private OrderItem GetOrderItem()
        {
            var orderDetail = new OrderItem
            {
                OrderId = _uow.OrderRepository.All.ToList().Max(x => x.OrderId) + 1,
                CookerId = 1,
                Description = "Includes six pieces.",
                DishId = 4,
                Instructions = null,
                MenuId = 1,
                OrderItemId = _uow.OrderItemRepository.All.ToList().Max(x => x.OrderItemId) + 1,
                Quantity = 2
            };

            orderDetail.OrderItemDishOptions.Add(GetItemDishOption());
            _uow.OrderItemRepository.Add(orderDetail);
            _uow.OrderItemDishOptionRepository.Add(GetItemDishOption());
            _uow.Save();
            return orderDetail;
        }

        #endregion

        #region OrderItemDishOption

        private OrderItemDishOption GetItemDishOption()
        {
            return new OrderItemDishOption
            {
                OrderItemDishOptionId = 3,
                DishOptionChoiceId = 20,
                DishOptionChoiceValue = "Extra Dressing",
                Price = (decimal?)0.53,
                CurrencyId = (int)CurrencyType.Values.Usd,
                DishOptionId = (int)DishOptionType.Values.FakeOptionalSideFourOptionChoices,
                Instructions = "no Mayone Please",
                OrderItemId = _uow.OrderItemRepository.All.ToList().Max(x => x.OrderItemId) + 1
            };
        }

        #endregion


        #endregion

        #endregion

        #endregion

        #region Step2

        private void CookerUpdateTransactionOrderstatusToIncoming(int? transactionOrderId)
        {
            Debug.Assert(transactionOrderId != null, "transactionOrderId != null");
            var currentOrderTransaction = _uow.OrderRepository.First(x => x.OrderId == transactionOrderId);
            Assert.AreEqual((int)OrderStatus.Values.Submitted, currentOrderTransaction.OrderStatusId);

            //Update Order Status to Incoming
            currentOrderTransaction.OrderStatusId = (int)OrderStatus.Values.Incoming;
            Assert.AreEqual((int)OrderStatus.Values.Incoming, currentOrderTransaction.OrderStatusId);
            _uow.Save();
        }

        private void CookerUpdateTransactionOrderstatusToDone(int? transactionOrderId)
        {
            Debug.Assert(transactionOrderId != null, "transactionOrderId != null");
            var currentOrderTransaction = _uow.OrderRepository.First(x => x.OrderId == transactionOrderId);
            Assert.AreEqual((int)OrderStatus.Values.Incoming, currentOrderTransaction.OrderStatusId);

            //Update Order Status to Active
            currentOrderTransaction.OrderStatusId = (int)OrderStatus.Values.Active;
            Assert.AreEqual((int)OrderStatus.Values.Active, currentOrderTransaction.OrderStatusId);
            _uow.Save();
        }

        #endregion

        #region Step3

        private void CookerUpdateOrderToReady(int? transactionOrderId)
        {
            Debug.Assert(transactionOrderId != null, "transactionOrderId != null");
            var currentOrderTransaction = _uow.OrderRepository.First(x => x.OrderId == transactionOrderId);
            Assert.AreEqual((int)OrderStatus.Values.Active, currentOrderTransaction.OrderStatusId);

            //Update Order Status to Incoming
            currentOrderTransaction.OrderStatusId = (int)OrderStatus.Values.Ready;
            Assert.AreEqual((int)OrderStatus.Values.Ready, currentOrderTransaction.OrderStatusId);
            _uow.Save();
        }

        private void ClientReviewOrder(OrderItem orderItem)
        {
            var clientOrderToReview = CreateClientOrdertoReview(orderItem);
            CreateClientOrderReviewSentToCooker(orderItem);
            var cookerOrderReviewReceived = CookerOrderReviewReceived(orderItem);
            DeleteClientOrderToReview(clientOrderToReview);

            UpdateCookerFeedBack_And_ReviewScore_And_ServiceDetail(cookerOrderReviewReceived);
        }

        private void CookerReviewOrder(OrderItem orderItem)
        {
            var cookerOrderToReview = CreateCookerOrderToReview(orderItem);
            CreateCookerOrderReviewSentToClient(orderItem);
            var clientOrderReviewReceived = ClientOrderReviewReceived(orderItem);
            DeleteCookerOrderToReview(cookerOrderToReview);

            UpdateClientFeedBack_And_ReviewScore(clientOrderReviewReceived);
        }

        #region Client Review

        private ClientOrderToReview CreateClientOrdertoReview(OrderItem orderItem)
        {
            Assert.AreEqual(0, _uow.ClientOrderToReviewRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
            // Client Order to Review
            var clientOrderToReview = new ClientOrderToReview
            {
                ClientOrderToReviewId = _uow.ClientOrderToReviewRepository.All.ToList().Max(x => x.ClientOrderToReviewId) + 1,
                ClientId = 2,
                CookerId = orderItem.CookerId,
                MenuId = orderItem.MenuId,
                OrderId = orderItem.OrderId,
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
            Assert.AreEqual(1, _uow.ClientOrderToReviewRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
            return clientOrderToReview;
        }

        private void CreateClientOrderReviewSentToCooker(OrderItem orderItem)
        {
            Assert.AreEqual(0, _uow.ClientOrderReviewSentRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
            var order = _uow.OrderRepository.FindBy(x => x.OrderId == orderItem.OrderId).FirstOrDefault();
            Debug.Assert(order != null, "order != null"); 
            var clientOrderReviewSent = new ClientOrderReviewSent
            {
                ClientOrderReviewSentId =
                    _uow.ClientOrderReviewSentRepository.All.ToList().Max(x => x.ClientOrderReviewSentId) + 1,
                ClientId = 2,
                CookerId = orderItem.CookerId,
                MenuId = orderItem.MenuId,
                OrderId = order.OrderId,
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
            Assert.AreEqual(1, _uow.ClientOrderReviewSentRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
        }

        private CookerOrderReviewReceived CookerOrderReviewReceived(OrderItem orderItem)
        {
            Assert.AreEqual(0, _uow.CookerOrderReviewReceivedRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
            //Cooker Review Received
            var cookerOrderReviewReceived = new CookerOrderReviewReceived
            {
                CookerOrderReviewReceivedId =
                    _uow.CookerOrderReviewReceivedRepository.All.ToList().Max(x => x.CookerOrderReviewReceivedId) + 1,
                CookerId = orderItem.CookerId,
                ClientId = 1,
                MenuId = orderItem.MenuId,
                OrderId = orderItem.OrderId,
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
            Assert.AreEqual(1, _uow.CookerOrderReviewReceivedRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
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

        private CookerOrderToReview CreateCookerOrderToReview(OrderItem orderItem)
        {
            Assert.AreEqual(0, _uow.CookerOrderToReviewRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
            // Cooker Order to Review
            var cookerOrderToReview = new CookerOrderToReview
            {
                CookerOrderToReviewId = _uow.CookerOrderToReviewRepository.All.ToList().Max(x => x.CookerOrderToReviewId) + 1,
                ClientId = 2,
                CookerId = orderItem.CookerId,
                MenuId = orderItem.MenuId,
                OrderId = orderItem.OrderId,
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
            Assert.AreEqual(1, _uow.CookerOrderToReviewRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
            return cookerOrderToReview;
        }

        private void CreateCookerOrderReviewSentToClient(OrderItem orderItem)
        {
            Assert.AreEqual(0, _uow.CookerOrderReviewSentRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
            //Cooker Review Order
            var cookerOrderReviewSent = new CookerOrderReviewSent
            {
                CookerOrderReviewSentId =
                    _uow.CookerOrderReviewSentRepository.All.ToList().Max(x => x.CookerOrderReviewSentId) + 1,
                ClientId = 2,
                CookerId = orderItem.CookerId,
                MenuId = orderItem.MenuId,
                OrderId = orderItem.OrderId,
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
            Assert.AreEqual(1, _uow.CookerOrderReviewSentRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
        }

        private ClientOrderReviewReceived ClientOrderReviewReceived(OrderItem orderItem)
        {
            Assert.AreEqual(0, _uow.ClientOrderReviewReceivedRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
            var clientOrderReviewReceived = new ClientOrderReviewReceived
            {
                ClientOrderReviewReceivedId = _uow.ClientOrderReviewReceivedRepository.All.ToList().Max(x => x.ClientOrderReviewReceivedId) + 1,
                CookerId = orderItem.CookerId,
                ClientId = 2,
                MenuId = orderItem.MenuId,
                OrderId = orderItem.OrderId,
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
            Assert.AreEqual(1, _uow.ClientOrderReviewReceivedRepository.FindBy(x => x.OrderId == orderItem.OrderId).Count());
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
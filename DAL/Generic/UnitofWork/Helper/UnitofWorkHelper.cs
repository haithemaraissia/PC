using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Fake.Model.GoodData.PaymentsHistory;
using DAL.Generic.Repository.Base;
using DAL.Generic.Repository.Model;
using DAL.Generic.Repository.Model.Fake;
using Model;
using PaymentsHistoryRepository = DAL.Generic.Repository.Model.PaymentsHistoryRepository;

namespace DAL.Generic.UnitofWork.Helper
{
    public class UnitofWorkHelper
    {
        public UnitofWorkHelper()
        {

        }

        public UnitofWork GetAllRepository()
        {
            return new UnitofWork
            {
                AddressTypeRepository = new FakeAddressTypeRepository(),
                ClientRepository = new FakeClientRepository(),
                ClientAddressRepository = new FakeClientAddressRepository(),
                ClientFeedBackRepository = new FakeClientFeedBackRepository(),
                ClientOrderReviewReceivedRepository = new FakeClientOrderReviewReceivedRepository(),
                ClientOrderReviewSentRepository = new FakeClientOrderReviewSentRepository(),
                ClientOrderToReviewRepository = new FakeClientOrderToReviewRepository(),
                ClientReviewScoreRepository = new FakeClientReviewScoreRepository(),
                ClientSubscriptionRepository = new FakeClientSubscriptionRepository(),
                CookerRepository = new FakeCookerRepository(),
                CookerCouponRepository = new FakeCookerCouponRepository(),
                CookerCuisineRepository = new FakeCookerCuisineRepository(),
                CookerDeliveryZoneRepository = new FakeCookerDeliveryZoneRepository(),
                CookerFeedBackRepository = new FakeCookerFeedBackRepository(),
                CookerGeoIPRepository = new FakeCookerGeoIpRepository(),
                CookerHoursofOperationRepository = new FakeCookerHoursofOperationRepository(),
                CookerMenuRepository = new FakeCookerMenuRepository(),
                CookerOrderReviewReceivedRepository = new FakeCookerOrderReviewReceivedRepository(),
                CookerOrderReviewSentRepository = new FakeCookerOrderReviewSentRepository(),
                CookerOrderToReviewRepository = new FakeCookerOrderToReviewRepository(),
                CookerPaymentMethodRepository = new FakeCookerPaymentMethodRepository(),
                CookerPlanRepository = new FakeCookerPlanRepository(),
                CookerPromotionRepository = new FakeCookerPromotionRepository(),
                CookerReviewScoreRepository = new FakeCookerReviewScoreRepository(),
                CookerReviewServiceDetailRepository = new FakeCookerReviewServiceDetailRepository(),
                CookerSpokenLanguageRepository = new FakeCookerSpokenLanguageRepository(),
                CookerSubscriptionRepository = new FakeCookerSubscriptionRepository(),
                CouponRepository = new FakeCouponRepository(),
                CouponTypeRepository = new FakeCouponTypeRepository(),
                CuisineTypeRepository = new FakeCuisineTypeRepository(),
                CurrencyRepository = new FakeCurrencyRepository(),
                DeliveryZoneRepository = new FakeDeliveryZoneRepository(),
                DishRepository = new FakeDishRepository(),
                DishOptionRepository = new FakeDishOptionRepository(),
                DishOptionsChoiceRepository = new FakeDishOptionsChoiceRepository(),
                DisputeRepository = new FakeDisputeRepository(),
                DisputeReasonRepository = new FakeDisputeReasonRepository(),
                DisputeStatuRepository = new FakeDisputeStatuRepository(),
                IndustryAverageRatingRepository = new FakeIndustryAverageRatingRepository(),
                InvoiceRepository = new FakeInvoiceRepository(),
                LanguageRepository = new FakeLanguageRepository(),
                MenuSectionRepository = new FakeMenuSectionRepository(),
                MostPopularDishRepository = new FakeMostPopularDishRepository(),
                MostPopularSubscriptionRepository = new FakeMostPopularSubscriptionRepository(),
                OrderRepository = new FakeOrderRepository(),
                OrderHistroyRepository = new FakeOrderHistroyRepository(),
                OrderItemRepository = new FakeOrderItemRepository(),
                OrderItemDishOptionRepository = new FakeOrderItemDishOptionRepository(),
                OrderModelTypeRepository = new FakeOrderModelTypeRepository(),
                OrderStatuRepository = new FakeOrderStatuRepository(),
                OrderSubscriptionRepository = new FakeOrderSubscriptionRepository(),
                OrderSubscriptionHistroyRepository = new FakeOrderSubscriptionHistroyRepository(),
                OrderSubscriptionItemRepository = new FakeOrderSubscriptionItemRepository(),
                OrderSubscriptionItemDishOptionRepository = new FakeOrderSubscriptionItemDishOptionRepository(),
                OrderTypeRepository = new FakeOrderTypeRepository(),
                PaymentRepository = new FakePaymentRepository(),
                PaymentMethodRepository = new FakePaymentMethodRepository(),
                PaymentsHistoryRepository = new FakePaymentsHistoryRepository(),
                PlanRepository = new FakePlanRepository(),
                PromotionRepository = new FakePromotionRepository(),
                PromotionTypeRepository = new FakePromotionTypeRepository(),
                RatingCodeRepository = new FakeRatingCodeRepository(),
                RefundRepository = new FakeRefundRepository(),
                ServingMeasurementRepository = new FakeServingMeasurementRepository(),
                ServingPriceRepository = new FakeServingPriceRepository(),
                UserRepository = new FakeUserRepository(),
                UserTypeRepository = new FakeUserTypeRepository(),
            };
        }


        ~UnitofWorkHelper()
        {

        }
    }


}

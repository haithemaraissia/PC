﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PrivateChefContext : DbContext
    {
        public PrivateChefContext()
            : base("name=PrivateChefContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<ClientAddress> ClientAddresses { get; set; }
        public virtual DbSet<ClientFeedBack> ClientFeedBacks { get; set; }
        public virtual DbSet<ClientOrderReviewReceived> ClientOrderReviewReceiveds { get; set; }
        public virtual DbSet<ClientOrderToReview> ClientOrderToReviews { get; set; }
        public virtual DbSet<ClientReviewScore> ClientReviewScores { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<CookerCoupon> CookerCoupons { get; set; }
        public virtual DbSet<CookerCuisine> CookerCuisines { get; set; }
        public virtual DbSet<CookerDeliveryZone> CookerDeliveryZones { get; set; }
        public virtual DbSet<CookerFeedBack> CookerFeedBacks { get; set; }
        public virtual DbSet<CookerGeoIP> CookerGeoIPs { get; set; }
        public virtual DbSet<CookerHoursofOperation> CookerHoursofOperations { get; set; }
        public virtual DbSet<CookerMenu> CookerMenus { get; set; }
        public virtual DbSet<CookerOrderReviewReceived> CookerOrderReviewReceiveds { get; set; }
        public virtual DbSet<CookerOrderReviewSent> CookerOrderReviewSents { get; set; }
        public virtual DbSet<CookerOrderToReview> CookerOrderToReviews { get; set; }
        public virtual DbSet<CookerPaymentMethod> CookerPaymentMethods { get; set; }
        public virtual DbSet<CookerPlan> CookerPlans { get; set; }
        public virtual DbSet<CookerPromotion> CookerPromotions { get; set; }
        public virtual DbSet<CookerReviewScore> CookerReviewScores { get; set; }
        public virtual DbSet<CookerReviewServiceDetail> CookerReviewServiceDetails { get; set; }
        public virtual DbSet<CookerSpokenLanguage> CookerSpokenLanguages { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<CouponType> CouponTypes { get; set; }
        public virtual DbSet<CuisineType> CuisineTypes { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<DeliveryZone> DeliveryZones { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<DishOption> DishOptions { get; set; }
        public virtual DbSet<DishOptionsChoice> DishOptionsChoices { get; set; }
        public virtual DbSet<IndustryAverageRating> IndustryAverageRatings { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MenuSection> MenuSections { get; set; }
        public virtual DbSet<OrderHistroy> OrderHistroys { get; set; }
        public virtual DbSet<OrderItemDishOption> OrderItemDishOptions { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderType> OrderTypes { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<PromotionType> PromotionTypes { get; set; }
        public virtual DbSet<RatingCode> RatingCodes { get; set; }
        public virtual DbSet<ServingMeasurement> ServingMeasurements { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<ClientAddress1> ClientAddresses1 { get; set; }
        public virtual DbSet<ClientOrderReviewSent> ClientOrderReviewSents { get; set; }
        public virtual DbSet<DisputeReason> DisputeReasons { get; set; }
        public virtual DbSet<DisputeStatu> DisputeStatus { get; set; }
        public virtual DbSet<OrderModelType> OrderModelTypes { get; set; }
        public virtual DbSet<Dispute> Disputes { get; set; }
        public virtual DbSet<Refund> Refunds { get; set; }
        public virtual DbSet<CookerSubscription> CookerSubscriptions { get; set; }
        public virtual DbSet<ServingPrice> ServingPrices { get; set; }
        public virtual DbSet<ClientSubscription> ClientSubscriptions { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<OrderSubscriptionHistroy> OrderSubscriptionHistroys { get; set; }
        public virtual DbSet<OrderSubscriptionItemDishOption> OrderSubscriptionItemDishOptions { get; set; }
        public virtual DbSet<OrderSubscriptionItem> OrderSubscriptionItems { get; set; }
        public virtual DbSet<OrderSubscription> OrderSubscriptions { get; set; }
        public virtual DbSet<PaymentsHistory> PaymentsHistories { get; set; }
        public virtual DbSet<MostPopularDish> MostPopularDishes { get; set; }
        public virtual DbSet<MostPopularSubscription> MostPopularSubscriptions { get; set; }
        public virtual DbSet<Cooker> Cookers { get; set; }
    }
}

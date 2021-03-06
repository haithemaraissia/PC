//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderSubscriptionHistroy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderSubscriptionHistoryId { get; set; }
        public int OrderSubscriptionId { get; set; }
        public int ClientId { get; set; }
        public Nullable<int> CookerId { get; set; }
        public string OrderTypeValue { get; set; }
        public string PaymentMethodValue { get; set; }
        public string PromotionTitle { get; set; }
        public Nullable<decimal> PromotionPrice { get; set; }
        public Nullable<int> PromotionCurrencyId { get; set; }
        public string CouponTitle { get; set; }
        public Nullable<decimal> CouponPrice { get; set; }
        public Nullable<int> CouponCurrencyId { get; set; }
        public string PlanTitle { get; set; }
        public Nullable<decimal> SalesTax { get; set; }
        public Nullable<decimal> DeliveryFees { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public int CurrencyId { get; set; }
        public int OrderStatusId { get; set; }
        public int ServingMeasurementId { get; set; }
        public int NumberofServingTotal { get; set; }
        public int ClientSubscriptionId { get; set; }
    }
}

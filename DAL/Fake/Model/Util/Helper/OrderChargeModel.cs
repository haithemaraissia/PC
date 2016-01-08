namespace DAL.Fake.Model.Util.Helper
{
    public class OrderChargeModel
    {
        #region Subscription

        public string PlanTitle { get; set; }

        #endregion

        #region Common

        public int CookerId { get; set; }
        public string OrderTypeValue { get; set; }
        public string PaymentMethodValue { get; set; }

        public string PromotionTitle { get; set; }
        public decimal PromotionPrice { get; set; }
        public int PromotionCurrencyId { get; set; }

        public string CouponTitle { get; set; }
        public decimal CouponPrice { get; set; }
        public int CouponCurrencyId { get; set; }

        public decimal Subtotal { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal SalesTaxes { get; set; }
        public decimal TotalCharges { get; set; }
    
    }
        #endregion


}

//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public string Description { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public string PromotionId { get; set; }
        public Nullable<double> CouponId { get; set; }
        public Nullable<int> PlanId { get; set; }
        public string Total { get; set; }
    }
}

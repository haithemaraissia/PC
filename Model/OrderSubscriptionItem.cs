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
    
    public partial class OrderSubscriptionItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderSubscriptionItem()
        {
            this.OrderSubscriptionItemDishOptions = new HashSet<OrderSubscriptionItemDishOption>();
        }
    
        public int OrderSubscriptionItemId { get; set; }
        public int DishId { get; set; }
        public int CookerId { get; set; }
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public int OrderSubscriptionId { get; set; }
        public int ClientOrderReviewSentClientOrderReviewSentId { get; set; }
        public int WeekId { get; set; }
        public System.DateTime ScheduledDate { get; set; }
    
        public virtual OrderSubscription OrderSubscription { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderSubscriptionItemDishOption> OrderSubscriptionItemDishOptions { get; set; }
    }
}

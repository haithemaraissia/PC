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
    
    public partial class OrderItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderItem()
        {
            this.OrderItemDishOptions = new HashSet<OrderItemDishOption>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemId { get; set; }
        public int DishId { get; set; }
        public int CookerId { get; set; }
        public int MenuId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public int OrderId { get; set; }
        public int ClientOrderReviewSentClientOrderReviewSentId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItemDishOption> OrderItemDishOptions { get; set; }
        public virtual Order Order { get; set; }
    }
}

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
    
    public partial class OrderSubscriptionItemDishOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderSubscriptionItemDishOptionId { get; set; }
        public int DishOptionChoiceId { get; set; }
        public string DishOptionChoiceValue { get; set; }
        public int DishOptionId { get; set; }
        public string Instructions { get; set; }
        public int OrderSubscriptionItemId { get; set; }
    
        public virtual OrderSubscriptionItem OrderSubscriptionItem { get; set; }
    }
}

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
    
    public partial class CookerFeedBack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CookerFeedBackId { get; set; }
        public int CookerId { get; set; }
        public string CookerRestaurantName { get; set; }
        public int TransactionsCount { get; set; }
        public int ReviewScore { get; set; }
        public decimal PositiveReview { get; set; }
    }
}

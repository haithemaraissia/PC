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
    
    public partial class Cooker
    {
        public int CookerId { get; set; }
        public int UserId { get; set; }
        public string RestaurantPhoto { get; set; }
        public string RestaurantName { get; set; }
        public string Cuisines { get; set; }
        public string PhoneNumber { get; set; }
        public string Bio { get; set; }
        public int Rating { get; set; }
        public int TotalRaters { get; set; }
        public bool OfferDelivery { get; set; }
        public bool OfferPickUp { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Model
{
    public partial class ClientOrderToReview
    {
        public int ClientOrderToReviewId { get; set; }
        public int ClientId { get; set; }
        public int CookerId { get; set; }
        public int MenuId { get; set; }
        public int OrderId { get; set; }
        public int OverallRating { get; set; }
        public int ItemAccuracyRating { get; set; }
        public int CommunicationRating { get; set; }
        public int DeliveryTimeRating { get; set; }
        public int OverallFeedBackRating { get; set; }
        public string Comment { get; set; }
        public string Photo { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderModelTypeId { get; set; }
    }
}

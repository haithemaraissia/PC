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
    
    public partial class ClientSubscription
    {
        public int ClientSubscriptionId { get; set; }
        public int ClientId { get; set; }
        public int CookerSubscriptionId { get; set; }
        public bool Active { get; set; }
        public System.DateTime ValidUntil { get; set; }
    }
}

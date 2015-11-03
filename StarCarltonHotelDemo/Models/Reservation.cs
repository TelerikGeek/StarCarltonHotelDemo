//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StarCarltonHotelDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public Nullable<System.DateTime> ReservationStartDate { get; set; }
        public Nullable<System.DateTime> ReservationEndDate { get; set; }
        public Nullable<int> NumOfOccupants { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public int ReservationStatusId { get; set; }
        public string ReservationCode { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ReservationStatus ReservationStatus { get; set; }
        public virtual Room Room { get; set; }
    }
}

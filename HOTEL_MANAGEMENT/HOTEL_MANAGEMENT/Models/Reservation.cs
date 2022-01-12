//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOTEL_MANAGEMENT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Reservation
    {
        public int Id_Reservation { get; set; }

        [Display(Name = "Date begin")]
        public System.DateTime Date_Begin { get; set; }

        [Display(Name = "Date end")]
        public System.DateTime Date_End { get; set; }

        [Display(Name = "Date reservation")]
        public System.DateTime Date_Reservation { get; set; }

        public double Bill { get; set; }

        [Display(Name = "Id user")]
        public int Id_user { get; set; }

        [Display(Name = "Id room")]
        public int Id_Room { get; set; }
    
        public virtual Room Room { get; set; }
        public virtual User User { get; set; }

        public static explicit operator Reservation(List<Reservation> v)
        {
            throw new NotImplementedException();
        }
    }
}

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
    
    public partial class Comment
    {
        public int Id_Comment { get; set; }
        public bool Opinion { get; set; }
        public string Comment1 { get; set; }
        public System.DateTime Date_Comment { get; set; }
        public int Id_user { get; set; }
        public int Id_Hotel { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual User User { get; set; }
    }
}

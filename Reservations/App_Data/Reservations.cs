//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reservations.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservations
    {
        public int id { get; set; }
        public Nullable<int> id_user { get; set; }
        public Nullable<int> id_room { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public System.DateTime date_start { get; set; }
        public System.DateTime date_end { get; set; }
        public int days { get; set; }
        public string payment { get; set; }
        public Nullable<int> cost { get; set; }
        public string status { get; set; }
    
        public virtual Rooms Rooms { get; set; }
        public virtual Users Users { get; set; }
    }
}

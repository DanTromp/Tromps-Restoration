//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tromps_Restoration
{
    using System;
    using System.Collections.Generic;
    
    public partial class Machine_Service
    {
        public int ServiceId { get; set; }
        public int Machine_ID { get; set; }
        public System.DateTime Day_Booked_Out { get; set; }
        public System.DateTime Day_Booked_In { get; set; }
        public decimal Cost_of_Service { get; set; }
    
        public virtual Machine Machine { get; set; }
    }
}

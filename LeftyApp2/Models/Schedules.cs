//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeftyApp2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedules
    {
        public int Id { get; set; }
        public string ScheduleName { get; set; }
        public string TradingPartner { get; set; }
        public string Direction { get; set; }
        public string TimeOfDay { get; set; }
        public string Schedule { get; set; }
        public string Exclusions { get; set; }
        public Nullable<System.TimeSpan> Deadline { get; set; }
        public bool Trackable { get; set; }
    }
}
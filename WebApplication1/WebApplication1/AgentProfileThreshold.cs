//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class AgentProfileThreshold
    {
        public int Id { get; set; }
        public Nullable<int> AgentProfileId { get; set; }
        public Nullable<int> MessageThresholdId { get; set; }
        public Nullable<bool> ThresholdMet { get; set; }
        public Nullable<System.DateTime> DateRecorded { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Events.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class FollowRequest
    {
        public int FollowRequestId { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public bool Approved { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
    }
}
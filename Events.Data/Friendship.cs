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
    
    public partial class Friendship
    {
        public int FriendshipId { get; set; }
        public string Friend1 { get; set; }
        public string Friend2 { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
    }
}

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
    
    public partial class Tag
    {
        public Tag()
        {
            this.EventTags = new HashSet<EventTag>();
        }
    
        public int TagId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<EventTag> EventTags { get; set; }
    }
}

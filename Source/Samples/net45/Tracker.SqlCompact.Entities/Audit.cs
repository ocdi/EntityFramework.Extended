//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tracker.SqlCompact.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Audit
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> TaskId { get; set; }
        public string Content { get; set; }
        public string Username { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual User User { get; set; }
    }
}

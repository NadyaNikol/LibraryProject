//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam2
{
    using System;
    using System.Collections.Generic;
    
    public partial class PendingBooks
    {
        public int Id { get; set; }
        public int IdInfo { get; set; }
        public int IdBook { get; set; }
        public System.DateTime ExpirationDate { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Info Info { get; set; }
    }
}

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
    
    public partial class Sales
    {
        public int Id { get; set; }
        public int IdBook { get; set; }
        public int IdShop { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Shops Shops { get; set; }
    }
}
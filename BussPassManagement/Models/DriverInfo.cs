//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BussPassManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DriverInfo
    {
        public int DriverID { get; set; }
        public string PassNumber { get; set; }
        public string FullName { get; set; }
        public string IdentityType { get; set; }
        public string IdentityCardno { get; set; }
        public Nullable<int> DestID { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> CompID { get; set; }
        public Nullable<int> ContactID { get; set; }
    
        public virtual contact contact { get; set; }
        public virtual busCompany busCompany { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inspection
    {
        public int Id { get; set; }
        public string InspectionsId { get; set; }
        public int EnquiryCategory { get; set; }
        public Nullable<int> NoFloors { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string ContactPerson { get; set; }
        public string AlternateNo { get; set; }
        public Nullable<int> Status { get; set; }
        public string Remark { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> InActiveDate { get; set; }
        public Nullable<int> InActineBy { get; set; }
        public string IPAddress { get; set; }
    
        public virtual EnquiryCategory EnquiryCategory1 { get; set; }
        public virtual EnquiryStatu EnquiryStatu { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TESA_Res_v0
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerTable
    {
        public string nameSurname { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string phoneNumber { get; set; }
        public string mail { get; set; }
        public Nullable<int> discountPer { get; set; }
        public Nullable<int> companyID { get; set; }
        public int customerID { get; set; }
    
        public virtual CompanyTable CompanyTable { get; set; }
    }
}
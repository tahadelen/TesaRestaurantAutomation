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
    
    public partial class Product_Categories_Table
    {
        public Product_Categories_Table()
        {
            this.Product_Product = new HashSet<Product_Product>();
            this.Product_Product1 = new HashSet<Product_Product>();
        }
    
        public int productID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public byte[] productImage { get; set; }
    
        public virtual Product_Categories_Table Product_Categories_Table1 { get; set; }
        public virtual Product_Categories_Table Product_Categories_Table2 { get; set; }
        public virtual ICollection<Product_Product> Product_Product { get; set; }
        public virtual ICollection<Product_Product> Product_Product1 { get; set; }
    }
}

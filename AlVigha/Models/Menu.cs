//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlVigha.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class Menu
    {
        public Menu()
        {
            this.Carts = new HashSet<Cart>();
            this.Order_Details = new HashSet<Order_Details>();
        }
    
        public int itemID { get; set; }
        public string itemName { get; set; }
        public string itemDesc { get; set; }
        public string itemImgpath { get; set; }
        public string itemCategory { get; set; }
        public string itemPrice { get; set; }
        public string itemSKU { get; set; }
        public HttpPostedFileBase imgFile { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order_Details> Order_Details { get; set; }

        
    }
}

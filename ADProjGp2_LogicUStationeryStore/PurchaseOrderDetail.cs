//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADProjGp2_LogicUStationeryStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrderDetail
    {
        public int id { get; set; }
        public string poId { get; set; }
        public string itemId { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
    
        public virtual Catalogue Catalogue { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
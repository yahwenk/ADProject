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
    
    public partial class AdjustmentDetail
    {
        public int id { get; set; }
        public string voucherId { get; set; }
        public string itemId { get; set; }
        public int quantity { get; set; }
        public string remark { get; set; }
    
        public virtual Adjustment Adjustment { get; set; }
        public virtual Catalogue Catalogue { get; set; }
    }
}

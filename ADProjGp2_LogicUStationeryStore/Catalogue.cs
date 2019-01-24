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
    
    public partial class Catalogue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Catalogue()
        {
            this.AdjustmentDetails = new HashSet<AdjustmentDetail>();
            this.DeliveryOrderDetails = new HashSet<DeliveryOrderDetail>();
            this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            this.RequisitionDetails = new HashSet<RequisitionDetail>();
            this.SpecialRequests = new HashSet<SpecialRequest>();
            this.SupplierQuotations = new HashSet<SupplierQuotation>();
        }
    
        public string itemId { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string unitOfMeasure { get; set; }
        public int reorderQuantity { get; set; }
        public int reorderLevel { get; set; }
        public string firstSupplier { get; set; }
        public string secondSupplier { get; set; }
        public string thirdSupplier { get; set; }
        public string bin { get; set; }
        public int quantityInUnit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdjustmentDetail> AdjustmentDetails { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Supplier Supplier1 { get; set; }
        public virtual Supplier Supplier2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryOrderDetail> DeliveryOrderDetails { get; set; }
        public virtual Inventory Inventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequisitionDetail> RequisitionDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialRequest> SpecialRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierQuotation> SupplierQuotations { get; set; }
    }
}

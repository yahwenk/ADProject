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
    
    public partial class Adjustment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adjustment()
        {
            this.AdjustmentDetails = new HashSet<AdjustmentDetail>();
        }
    
        public string voucherId { get; set; }
        public System.DateTime date { get; set; }
        public string clerk { get; set; }
        public string supervisor { get; set; }
        public string needAuthority { get; set; }
        public string status { get; set; }
        public Nullable<decimal> adjustmentValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdjustmentDetail> AdjustmentDetails { get; set; }
    }
}

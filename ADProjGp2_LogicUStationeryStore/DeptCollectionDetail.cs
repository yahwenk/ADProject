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
    
    public partial class DeptCollectionDetail
    {
        public string departmentId { get; set; }
        public string departmentName { get; set; }
        public string collectionPoint { get; set; }
        public string representative { get; set; }
        public string authorisedPerson { get; set; }
        public Nullable<System.DateTime> validDateStart { get; set; }
        public Nullable<System.DateTime> validDateEnd { get; set; }
    
        public virtual CollectionPoint CollectionPoint1 { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lottodo_webapi2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ltd_tbl_plantypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ltd_tbl_plantypes()
        {
            this.ltd_tbl_plan = new HashSet<ltd_tbl_plan>();
            this.ltd_tbl_plansubtypes = new HashSet<ltd_tbl_plansubtypes>();
        }
    
        public int ltd_PlanTypeId { get; set; }
        public string ltd_PlanTypeName { get; set; }
        public string ltd_PlanTypeDescription { get; set; }
        public bool ltd_Active { get; set; }
        public string ltd_AddInfo { get; set; }
        public System.DateTime ltd_CreatedDate { get; set; }
        public System.DateTime ltd_ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ltd_tbl_plan> ltd_tbl_plan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ltd_tbl_plansubtypes> ltd_tbl_plansubtypes { get; set; }
    }
}

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
    
    public partial class ltd_tbl_userdetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ltd_tbl_userdetails()
        {
            this.ltd_tbl_groupmembers = new HashSet<ltd_tbl_groupmembers>();
            this.ltd_tbl_messages = new HashSet<ltd_tbl_messages>();
            this.ltd_tbl_plan = new HashSet<ltd_tbl_plan>();
        }
    
        public string ltd_UserId { get; set; }
        public string ltd_FullName { get; set; }
        public string ltd_Email { get; set; }
        public string ltd_Password { get; set; }
        public bool ltd_FBConnected { get; set; }
        public bool ltd_Active { get; set; }
        public string ltd_AddInfo { get; set; }
        public System.DateTime ltd_CreatedDate { get; set; }
        public System.DateTime ltd_ModifiedDate { get; set; }
    
        public virtual ltd_tbl_fbdetails ltd_tbl_fbdetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ltd_tbl_groupmembers> ltd_tbl_groupmembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ltd_tbl_messages> ltd_tbl_messages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ltd_tbl_plan> ltd_tbl_plan { get; set; }
    }
}

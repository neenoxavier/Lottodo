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
    
    public partial class ltd_tbl_groupmembers
    {
        public int ltd_GroupId { get; set; }
        public string ltd_UserId { get; set; }
        public string ltd_Status { get; set; }
        public bool ltd_Active { get; set; }
        public string ltd_AddInfo { get; set; }
        public System.DateTime ltd_CreatedDate { get; set; }
        public System.DateTime ltd_ModifiedDate { get; set; }
    
        public virtual ltd_tbl_userdetails ltd_tbl_userdetails { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ltd_tbl_chatgroups> ltd_tbl_chatgroups { get; set; }
        public virtual DbSet<ltd_tbl_fbdetails> ltd_tbl_fbdetails { get; set; }
        public virtual DbSet<ltd_tbl_groupmembers> ltd_tbl_groupmembers { get; set; }
        public virtual DbSet<ltd_tbl_messages> ltd_tbl_messages { get; set; }
        public virtual DbSet<ltd_tbl_plan> ltd_tbl_plan { get; set; }
        public virtual DbSet<ltd_tbl_plansubtypes> ltd_tbl_plansubtypes { get; set; }
        public virtual DbSet<ltd_tbl_plantypes> ltd_tbl_plantypes { get; set; }
        public virtual DbSet<ltd_tbl_userdetails> ltd_tbl_userdetails { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebTruyenHay.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class truyenhayEntities7 : DbContext
    {
        public truyenhayEntities7()
            : base("name=truyenhayEntities7")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chuong> Chuongs { get; set; }
        public virtual DbSet<DanhGia> DanhGias { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DanhSachDoc> DanhSachDocs { get; set; }
        public virtual DbSet<DanhSachDocTruyen> DanhSachDocTruyens { get; set; }
        public virtual DbSet<Giaodich> Giaodiches { get; set; }
        public virtual DbSet<imagechuong> imagechuongs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<ThongBao> ThongBaos { get; set; }
        public virtual DbSet<TienDoDoc> TienDoDocs { get; set; }
        public virtual DbSet<Truyen> Truyens { get; set; }
        public virtual DbSet<TruyenDanhMuc> TruyenDanhMucs { get; set; }
        public virtual DbSet<truyeniuthich> truyeniuthiches { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLyQuanCaFeEntities : DbContext
    {
        public QuanLyQuanCaFeEntities()
            : base("name=QuanLyQuanCaFeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BAN> BANs { get; set; }
        public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<LOAIMENU> LOAIMENUs { get; set; }
        public virtual DbSet<LOAITK> LOAITKs { get; set; }
        public virtual DbSet<MENU> MENUs { get; set; }
        public virtual DbSet<NGUYENLIEU> NGUYENLIEUx { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
    
        public virtual int ChuyenBan(Nullable<int> iDCu, Nullable<int> iDMoi)
        {
            var iDCuParameter = iDCu.HasValue ?
                new ObjectParameter("IDCu", iDCu) :
                new ObjectParameter("IDCu", typeof(int));
    
            var iDMoiParameter = iDMoi.HasValue ?
                new ObjectParameter("IDMoi", iDMoi) :
                new ObjectParameter("IDMoi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChuyenBan", iDCuParameter, iDMoiParameter);
        }
    
        public virtual ObjectResult<GetBill_Result> GetBill(Nullable<int> maBan)
        {
            var maBanParameter = maBan.HasValue ?
                new ObjectParameter("maBan", maBan) :
                new ObjectParameter("maBan", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBill_Result>("GetBill", maBanParameter);
        }
    
        public virtual ObjectResult<getListHD_Result> getListHD(Nullable<System.DateTime> tuNgay, Nullable<System.DateTime> denNgay)
        {
            var tuNgayParameter = tuNgay.HasValue ?
                new ObjectParameter("TuNgay", tuNgay) :
                new ObjectParameter("TuNgay", typeof(System.DateTime));
    
            var denNgayParameter = denNgay.HasValue ?
                new ObjectParameter("DenNgay", denNgay) :
                new ObjectParameter("DenNgay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getListHD_Result>("getListHD", tuNgayParameter, denNgayParameter);
        }
    
        public virtual int inserBill(Nullable<int> idTable, Nullable<int> maNv)
        {
            var idTableParameter = idTable.HasValue ?
                new ObjectParameter("idTable", idTable) :
                new ObjectParameter("idTable", typeof(int));
    
            var maNvParameter = maNv.HasValue ?
                new ObjectParameter("maNv", maNv) :
                new ObjectParameter("maNv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("inserBill", idTableParameter, maNvParameter);
        }
    
        public virtual int inserBillInfo(Nullable<int> maHd, Nullable<int> maMenu, Nullable<int> soLuong, Nullable<double> giamGia, Nullable<double> giaBan)
        {
            var maHdParameter = maHd.HasValue ?
                new ObjectParameter("MaHd", maHd) :
                new ObjectParameter("MaHd", typeof(int));
    
            var maMenuParameter = maMenu.HasValue ?
                new ObjectParameter("MaMenu", maMenu) :
                new ObjectParameter("MaMenu", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var giamGiaParameter = giamGia.HasValue ?
                new ObjectParameter("GiamGia", giamGia) :
                new ObjectParameter("GiamGia", typeof(double));
    
            var giaBanParameter = giaBan.HasValue ?
                new ObjectParameter("GiaBan", giaBan) :
                new ObjectParameter("GiaBan", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("inserBillInfo", maHdParameter, maMenuParameter, soLuongParameter, giamGiaParameter, giaBanParameter);
        }
    
        public virtual int insertBillInfo(Nullable<int> maHd, Nullable<int> maMenu, Nullable<int> soLuong, Nullable<double> giamGia, Nullable<double> giaBan)
        {
            var maHdParameter = maHd.HasValue ?
                new ObjectParameter("MaHd", maHd) :
                new ObjectParameter("MaHd", typeof(int));
    
            var maMenuParameter = maMenu.HasValue ?
                new ObjectParameter("MaMenu", maMenu) :
                new ObjectParameter("MaMenu", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var giamGiaParameter = giamGia.HasValue ?
                new ObjectParameter("GiamGia", giamGia) :
                new ObjectParameter("GiamGia", typeof(double));
    
            var giaBanParameter = giaBan.HasValue ?
                new ObjectParameter("GiaBan", giaBan) :
                new ObjectParameter("GiaBan", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertBillInfo", maHdParameter, maMenuParameter, soLuongParameter, giamGiaParameter, giaBanParameter);
        }
    
        public virtual ObjectResult<QuanLyBan_Result> QuanLyBan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<QuanLyBan_Result>("QuanLyBan");
        }
    
        public virtual int updteBill(Nullable<int> maHd, Nullable<System.DateTime> ngay)
        {
            var maHdParameter = maHd.HasValue ?
                new ObjectParameter("maHd", maHd) :
                new ObjectParameter("maHd", typeof(int));
    
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("Ngay", ngay) :
                new ObjectParameter("Ngay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updteBill", maHdParameter, ngayParameter);
        }
    }
}

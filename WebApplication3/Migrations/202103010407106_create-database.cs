namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.hanghoas",
                c => new
                    {
                        MaHangHoa = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenHH = c.String(nullable: false, maxLength: 50, unicode: false),
                        DonGia = c.Decimal(nullable: false, precision: 18, scale: 0),
                        DonViTinh = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNCC = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.MaHangHoa);
            
            CreateTable(
                "dbo.khachhangs",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenKhachHang = c.String(maxLength: 50, unicode: false),
                        SoDienThoai = c.String(maxLength: 11, unicode: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.Nhaccs",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenNCC = c.String(maxLength: 50, unicode: false),
                        SoDienThoai = c.String(maxLength: 11, fixedLength: true),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            CreateTable(
                "dbo.nhaps",
                c => new
                    {
                        STT = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        MaPhieuNhap = c.String(maxLength: 50),
                        MaHangHoa = c.String(maxLength: 10, fixedLength: true),
                        SoLuong = c.Int(),
                        NgayNhap = c.DateTime(storeType: "date"),
                        MaNCCS = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.STT);
            
            CreateTable(
                "dbo.phieunhap",
                c => new
                    {
                        MaPhieuNhap = c.Int(nullable: false),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        MaNCC = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaPhieuNhap);
            
            CreateTable(
                "dbo.phieuxuat",
                c => new
                    {
                        MaPhieuXuat = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        MaKhachHang = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MaPhieuXuat);
            
            CreateTable(
                "dbo.tonkho",
                c => new
                    {
                        STT = c.Int(nullable: false),
                        MaHangHoa = c.String(nullable: false, maxLength: 50, unicode: false),
                        SoNhap = c.Int(nullable: false),
                        SoXuat = c.Int(nullable: false),
                        SoTon = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.STT);
            
            CreateTable(
                "dbo.xuat",
                c => new
                    {
                        STT = c.Int(nullable: false),
                        MaPhieuXuat = c.String(nullable: false, maxLength: 50),
                        MaHangHoa = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        SoLuong = c.Int(nullable: false),
                        NgayXuat = c.DateTime(nullable: false, storeType: "date"),
                        MaKhachHang = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.STT);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.xuat");
            DropTable("dbo.tonkho");
            DropTable("dbo.phieuxuat");
            DropTable("dbo.phieunhap");
            DropTable("dbo.nhaps");
            DropTable("dbo.Nhaccs");
            DropTable("dbo.khachhangs");
            DropTable("dbo.hanghoas");
        }
    }
}

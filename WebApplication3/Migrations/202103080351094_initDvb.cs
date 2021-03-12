namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDvb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhaccs",
                c => new
                {
                    Ma = c.String(nullable: false, maxLength: 50),
                    TenNCC = c.String(maxLength: 50),
                    SoDienThoai = c.String(maxLength: 11),
                })
                .PrimaryKey(t => t.Ma);

            CreateTable(
                "dbo.hanghoas",
                c => new
                    {
                        MaHangHoa = c.String(nullable: false, maxLength: 50),
                        TenHH = c.String(nullable: false, maxLength: 50),
                        DonGia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DonViTinh = c.String(nullable: false, maxLength: 50),
                        MaNCC = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaHangHoa)
                .ForeignKey("dbo.Nhaccs", t => t.MaNCC, cascadeDelete: true)
                .Index(t => t.MaNCC);
            
            CreateTable(
                "dbo.khachhangs",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 50),
                        TenKhachHang = c.String(maxLength: 50),
                        SoDienThoai = c.String(maxLength: 11),
                        Nhacc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.nhaps",
                c => new
                    {
                        STT = c.String(nullable: false, maxLength: 10),
                        MaPhieuNhap = c.String(maxLength: 50),
                        MaHangHoa = c.String(maxLength: 10),
                        SoLuong = c.Int(),
                        NgayNhap = c.DateTime(storeType: "date"),
                        MaNCCS = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.STT);
            
            CreateTable(
                "dbo.phieunhap",
                c => new
                    {
                        MaPhieuNhap = c.Int(nullable: false),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        MaNCC = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhieuNhap);
            
            CreateTable(
                "dbo.phieuxuat",
                c => new
                    {
                        MaPhieuXuat = c.String(nullable: false, maxLength: 10),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        MaKhachHang = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhieuXuat);
            
            CreateTable(
                "dbo.tonkho",
                c => new
                    {
                        STT = c.Int(nullable: false),
                        MaHangHoa = c.String(nullable: false, maxLength: 50),
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
                        MaHangHoa = c.String(nullable: false, maxLength: 20),
                        SoLuong = c.Int(nullable: false),
                        NgayXuat = c.DateTime(nullable: false, storeType: "date"),
                        MaKhachHang = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.STT);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.hanghoas", "MaNCC", "dbo.Nhaccs");
            DropIndex("dbo.hanghoas", new[] { "MaNCC" });
            DropTable("dbo.xuat");
            DropTable("dbo.tonkho");
            DropTable("dbo.phieuxuat");
            DropTable("dbo.phieunhap");
            DropTable("dbo.nhaps");
            DropTable("dbo.khachhangs");
            DropTable("dbo.Nhaccs");
            DropTable("dbo.hanghoas");
        }
    }
}

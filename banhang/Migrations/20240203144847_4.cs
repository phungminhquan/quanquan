using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDons_HoaDons_HoaDonId",
                table: "ChiTietHoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDons_SanPhams_SanPhamId",
                table: "ChiTietHoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangId",
                table: "HoaDons");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPhams_LoaiSanPhams_LoaiSanPhamId",
                table: "SanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiSanPhams",
                table: "LoaiSanPhams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDons",
                table: "HoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons");

            migrationBuilder.DropColumn(
                name: "DaHetHan",
                table: "SanPhams");

            migrationBuilder.DropColumn(
                name: "SoLuongTonKho",
                table: "SanPhams");

            migrationBuilder.RenameTable(
                name: "SanPhams",
                newName: "SanPham_tbl");

            migrationBuilder.RenameTable(
                name: "LoaiSanPhams",
                newName: "LoaiSanPham_tbl");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang_tbl");

            migrationBuilder.RenameTable(
                name: "HoaDons",
                newName: "HoaDon_tbl");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDons",
                newName: "ChiTietHoaDon_tbl");

            migrationBuilder.RenameIndex(
                name: "IX_SanPhams_LoaiSanPhamId",
                table: "SanPham_tbl",
                newName: "IX_SanPham_tbl_LoaiSanPhamId");

            migrationBuilder.RenameColumn(
                name: "HoTen",
                table: "KhachHang_tbl",
                newName: "TenKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_KhachHangId",
                table: "HoaDon_tbl",
                newName: "IX_HoaDon_tbl_KhachHangId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDons_SanPhamId",
                table: "ChiTietHoaDon_tbl",
                newName: "IX_ChiTietHoaDon_tbl_SanPhamId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDons_HoaDonId",
                table: "ChiTietHoaDon_tbl",
                newName: "IX_ChiTietHoaDon_tbl_HoaDonId");

            migrationBuilder.AlterColumn<double>(
                name: "TongTien",
                table: "HoaDon_tbl",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThoiGianCapNhat",
                table: "HoaDon_tbl",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KhachHangId",
                table: "HoaDon_tbl",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KhachHangId",
                table: "ChiTietHoaDon_tbl",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPham_tbl",
                table: "SanPham_tbl",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiSanPham_tbl",
                table: "LoaiSanPham_tbl",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang_tbl",
                table: "KhachHang_tbl",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDon_tbl",
                table: "HoaDon_tbl",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDon_tbl",
                table: "ChiTietHoaDon_tbl",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_tbl_KhachHangId",
                table: "ChiTietHoaDon_tbl",
                column: "KhachHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_tbl_HoaDon_tbl_HoaDonId",
                table: "ChiTietHoaDon_tbl",
                column: "HoaDonId",
                principalTable: "HoaDon_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_tbl_KhachHang_tbl_KhachHangId",
                table: "ChiTietHoaDon_tbl",
                column: "KhachHangId",
                principalTable: "KhachHang_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_tbl_SanPham_tbl_SanPhamId",
                table: "ChiTietHoaDon_tbl",
                column: "SanPhamId",
                principalTable: "SanPham_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_tbl_KhachHang_tbl_KhachHangId",
                table: "HoaDon_tbl",
                column: "KhachHangId",
                principalTable: "KhachHang_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_tbl_LoaiSanPham_tbl_LoaiSanPhamId",
                table: "SanPham_tbl",
                column: "LoaiSanPhamId",
                principalTable: "LoaiSanPham_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_tbl_HoaDon_tbl_HoaDonId",
                table: "ChiTietHoaDon_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_tbl_KhachHang_tbl_KhachHangId",
                table: "ChiTietHoaDon_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_tbl_SanPham_tbl_SanPhamId",
                table: "ChiTietHoaDon_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_tbl_KhachHang_tbl_KhachHangId",
                table: "HoaDon_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_tbl_LoaiSanPham_tbl_LoaiSanPhamId",
                table: "SanPham_tbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SanPham_tbl",
                table: "SanPham_tbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoaiSanPham_tbl",
                table: "LoaiSanPham_tbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang_tbl",
                table: "KhachHang_tbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDon_tbl",
                table: "HoaDon_tbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietHoaDon_tbl",
                table: "ChiTietHoaDon_tbl");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDon_tbl_KhachHangId",
                table: "ChiTietHoaDon_tbl");

            migrationBuilder.DropColumn(
                name: "KhachHangId",
                table: "ChiTietHoaDon_tbl");

            migrationBuilder.RenameTable(
                name: "SanPham_tbl",
                newName: "SanPhams");

            migrationBuilder.RenameTable(
                name: "LoaiSanPham_tbl",
                newName: "LoaiSanPhams");

            migrationBuilder.RenameTable(
                name: "KhachHang_tbl",
                newName: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "HoaDon_tbl",
                newName: "HoaDons");

            migrationBuilder.RenameTable(
                name: "ChiTietHoaDon_tbl",
                newName: "ChiTietHoaDons");

            migrationBuilder.RenameIndex(
                name: "IX_SanPham_tbl_LoaiSanPhamId",
                table: "SanPhams",
                newName: "IX_SanPhams_LoaiSanPhamId");

            migrationBuilder.RenameColumn(
                name: "TenKhachHang",
                table: "KhachHangs",
                newName: "HoTen");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_tbl_KhachHangId",
                table: "HoaDons",
                newName: "IX_HoaDons_KhachHangId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDon_tbl_SanPhamId",
                table: "ChiTietHoaDons",
                newName: "IX_ChiTietHoaDons_SanPhamId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietHoaDon_tbl_HoaDonId",
                table: "ChiTietHoaDons",
                newName: "IX_ChiTietHoaDons_HoaDonId");

            migrationBuilder.AddColumn<bool>(
                name: "DaHetHan",
                table: "SanPhams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongTonKho",
                table: "SanPhams",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TongTien",
                table: "HoaDons",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThoiGianCapNhat",
                table: "HoaDons",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "KhachHangId",
                table: "HoaDons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SanPhams",
                table: "SanPhams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoaiSanPhams",
                table: "LoaiSanPhams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDons",
                table: "HoaDons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietHoaDons",
                table: "ChiTietHoaDons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDons_HoaDons_HoaDonId",
                table: "ChiTietHoaDons",
                column: "HoaDonId",
                principalTable: "HoaDons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDons_SanPhams_SanPhamId",
                table: "ChiTietHoaDons",
                column: "SanPhamId",
                principalTable: "SanPhams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPhams_LoaiSanPhams_LoaiSanPhamId",
                table: "SanPhams",
                column: "LoaiSanPhamId",
                principalTable: "LoaiSanPhams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace banhang.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_tbl_HoaDon_tbl_HoaDonId",
                table: "ChiTietHoaDon_tbl");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_tbl_KhachHang_tbl_KhachHangId",
                table: "ChiTietHoaDon_tbl");

            migrationBuilder.AlterColumn<double>(
                name: "TongTien",
                table: "HoaDon_tbl",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ThoiGianTao",
                table: "HoaDon_tbl",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "MaGiaoDich",
                table: "HoaDon_tbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "ThanhTien",
                table: "ChiTietHoaDon_tbl",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "KhachHangId",
                table: "ChiTietHoaDon_tbl",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HoaDonId",
                table: "ChiTietHoaDon_tbl",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_tbl_HoaDon_tbl_HoaDonId",
                table: "ChiTietHoaDon_tbl",
                column: "HoaDonId",
                principalTable: "HoaDon_tbl",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_tbl_KhachHang_tbl_KhachHangId",
                table: "ChiTietHoaDon_tbl",
                column: "KhachHangId",
                principalTable: "KhachHang_tbl",
                principalColumn: "Id");
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
                name: "ThoiGianTao",
                table: "HoaDon_tbl",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaGiaoDich",
                table: "HoaDon_tbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ThanhTien",
                table: "ChiTietHoaDon_tbl",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KhachHangId",
                table: "ChiTietHoaDon_tbl",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HoaDonId",
                table: "ChiTietHoaDon_tbl",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_tbl_HoaDon_tbl_HoaDonId",
                table: "ChiTietHoaDon_tbl",
                column: "HoaDonId",
                principalTable: "HoaDon_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_tbl_KhachHang_tbl_KhachHangId",
                table: "ChiTietHoaDon_tbl",
                column: "KhachHangId",
                principalTable: "KhachHang_tbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

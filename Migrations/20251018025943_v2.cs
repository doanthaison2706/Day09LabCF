using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ĐTSDay9Lesson.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSanPham_LoaiSanPhamId1",
                table: "SanPham");

            migrationBuilder.RenameColumn(
                name: "TenSanPham",
                table: "SanPham",
                newName: "DTSTenSanPham");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "SanPham",
                newName: "DTSSoLuong");

            migrationBuilder.RenameColumn(
                name: "MaSanPham",
                table: "SanPham",
                newName: "DTSMaSanPham");

            migrationBuilder.RenameColumn(
                name: "LoaiSanPhamId1",
                table: "SanPham",
                newName: "DTSLoaiSanPhamDTSId");

            migrationBuilder.RenameColumn(
                name: "LoaiSanPhamId",
                table: "SanPham",
                newName: "DTSLoaiSanPhamId");

            migrationBuilder.RenameColumn(
                name: "HinhAnh",
                table: "SanPham",
                newName: "DTSHinhAnh");

            migrationBuilder.RenameColumn(
                name: "DonGia",
                table: "SanPham",
                newName: "DTSDonGia");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SanPham",
                newName: "DTSId");

            migrationBuilder.RenameIndex(
                name: "IX_SanPham_LoaiSanPhamId1",
                table: "SanPham",
                newName: "IX_SanPham_DTSLoaiSanPhamDTSId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LoaiSanPham",
                newName: "DTSId");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSanPham_DTSLoaiSanPhamDTSId",
                table: "SanPham",
                column: "DTSLoaiSanPhamDTSId",
                principalTable: "LoaiSanPham",
                principalColumn: "DTSId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSanPham_DTSLoaiSanPhamDTSId",
                table: "SanPham");

            migrationBuilder.RenameColumn(
                name: "DTSTenSanPham",
                table: "SanPham",
                newName: "TenSanPham");

            migrationBuilder.RenameColumn(
                name: "DTSSoLuong",
                table: "SanPham",
                newName: "SoLuong");

            migrationBuilder.RenameColumn(
                name: "DTSMaSanPham",
                table: "SanPham",
                newName: "MaSanPham");

            migrationBuilder.RenameColumn(
                name: "DTSLoaiSanPhamId",
                table: "SanPham",
                newName: "LoaiSanPhamId");

            migrationBuilder.RenameColumn(
                name: "DTSLoaiSanPhamDTSId",
                table: "SanPham",
                newName: "LoaiSanPhamId1");

            migrationBuilder.RenameColumn(
                name: "DTSHinhAnh",
                table: "SanPham",
                newName: "HinhAnh");

            migrationBuilder.RenameColumn(
                name: "DTSDonGia",
                table: "SanPham",
                newName: "DonGia");

            migrationBuilder.RenameColumn(
                name: "DTSId",
                table: "SanPham",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_SanPham_DTSLoaiSanPhamDTSId",
                table: "SanPham",
                newName: "IX_SanPham_LoaiSanPhamId1");

            migrationBuilder.RenameColumn(
                name: "DTSId",
                table: "LoaiSanPham",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSanPham_LoaiSanPhamId1",
                table: "SanPham",
                column: "LoaiSanPhamId1",
                principalTable: "LoaiSanPham",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

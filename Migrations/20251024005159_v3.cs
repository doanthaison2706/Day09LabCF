using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ĐTSDay9Lesson.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSanPham_DTSLoaiSanPhamDTSId",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_DTSLoaiSanPhamDTSId",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "DTSLoaiSanPhamDTSId",
                table: "SanPham");

            migrationBuilder.AlterColumn<int>(
                name: "DTSId",
                table: "SanPham",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSanPham_DTSId",
                table: "SanPham",
                column: "DTSId",
                principalTable: "LoaiSanPham",
                principalColumn: "DTSId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_LoaiSanPham_DTSId",
                table: "SanPham");

            migrationBuilder.AlterColumn<int>(
                name: "DTSId",
                table: "SanPham",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DTSLoaiSanPhamDTSId",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_DTSLoaiSanPhamDTSId",
                table: "SanPham",
                column: "DTSLoaiSanPhamDTSId");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_LoaiSanPham_DTSLoaiSanPhamDTSId",
                table: "SanPham",
                column: "DTSLoaiSanPhamDTSId",
                principalTable: "LoaiSanPham",
                principalColumn: "DTSId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

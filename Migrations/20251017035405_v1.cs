using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ĐTSDay9Lesson.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DTSMaLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DTSTenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DTSTrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoaiSanPhamId = table.Column<long>(type: "bigint", nullable: false),
                    LoaiSanPhamId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_LoaiSanPhamId1",
                        column: x => x.LoaiSanPhamId1,
                        principalTable: "LoaiSanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoaiSanPham_DTSMaLoai",
                table: "LoaiSanPham",
                column: "DTSMaLoai",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSanPhamId1",
                table: "SanPham",
                column: "LoaiSanPhamId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");
        }
    }
}

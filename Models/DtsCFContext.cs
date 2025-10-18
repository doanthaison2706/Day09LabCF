using Microsoft.EntityFrameworkCore;
namespace ĐTSDay9Lesson.Models
{
    public class DtsCFContext : DbContext
    {
        public DtsCFContext(DbContextOptions<DtsCFContext> options) : base(options)
        {
        }
        public DbSet<DtsLoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<DtsSanPham> SanPhams { get; set; }
    }
}

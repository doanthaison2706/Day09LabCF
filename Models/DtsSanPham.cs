using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ĐTSDay9Lesson.Models
{
    [Table("SanPham")]
    public class DtsSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DTSId { get; set; }
        [Display(Name = "Mã sản phẩm")]
        [StringLength(100)]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống")]
        public string DTSMaSanPham { get; set; }
        [Display(Name = "Tên sản phẩm")]
        [StringLength(200)]
        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        public string DTSTenSanPham { get; set; }
        [Display(Name = "Hình Ảnh")]
        public string DTSHinhAnh { get; set; }
        [Display(Name = "Số Lượng")]
        public int DTSSoLuong { get; set; }
        [Display(Name = "Đơn Giá")]
        public decimal DTSDonGia { get; set; }
        public long DTSLoaiSanPhamId { get; set; }
        [ForeignKey(nameof(DTSId))]
        public DtsLoaiSanPham? DTSLoaiSanPham { get; set; }

    }
}

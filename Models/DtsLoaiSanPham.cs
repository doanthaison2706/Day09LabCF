using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ĐTSDay9Lesson.Models
{
    [Table("LoaiSanPham")]
    [Index(nameof(DTSMaLoai), IsUnique = true)]
    public class DtsLoaiSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DTSId { get; set; }
        [Display(Name = "Mã loại sản phẩm")]
        [StringLength(100)]
        [Required(ErrorMessage = "Tên loại sản phẩm không được để trống")]
        public string DTSMaLoai { get; set; }
        [Display(Name = "Tên loại sản phẩm")]
        [StringLength(100)]
        [Required(ErrorMessage = "Tên loại sản phẩm không được để trống")]
        public string DTSTenLoai { get; set; }
        [Display(Name = "Trạng thái")]
        public bool DTSTrangThai { get; set; }
        
        public ICollection<DtsSanPham> DTSSanPhams { get; set; }

    }
}

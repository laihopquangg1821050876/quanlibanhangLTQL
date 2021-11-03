using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTLLTQL.Models
{
    [Table("HangHoas")]
    public class HangHoa

    {
        [Key]
        [StringLength(50, ErrorMessage = "Mã Hàng Hóa Phải Ngắn hơn 50 ký tự")]
        [DisplayName(" mã hàng hóa")]
        public string MaHang { get; set; }
        [DisplayName(" tên hàng hóa")]
        [Required]
        [StringLength(50)]
        public string Tenhang { get; set; }
        [DisplayName(" đơn giá ")]
        public decimal DonGia { get; set; }
        [DisplayName(" đơn  vị tính ")]
        [Required]
        [StringLength(50)]
        public string DonViTinh { get; set; }
        [AllowHtml]
        [Required]
        [StringLength(50)]

        [DisplayName("Nhà Cung Cấp")]
        public string MaNCC { get; set; }
        [ForeignKey("MaNCC")]
        public string NhaCCs { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLLTQL.Models
{
    public class phieunhap
    {
        [Key]
        public string MaPhieunhap { get; set; }
        public string Masanpham { get; set; }
        public string tensanpham { get; set;  }
        [Column(TypeName ="date")]
        public DateTime Ngaytao { get; set; }
    }
}
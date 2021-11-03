using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLLTQL.Models
{
    [Table("tonkho")]
    public class TonKho
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STT { get; set; }

        [Required]
        [StringLength(50)]
        public string Mahang { get; set; }

        public int SoNhap { get; set; }

        public int SoXuat { get; set; }

        public int SoTon { get; set; }
    }
}
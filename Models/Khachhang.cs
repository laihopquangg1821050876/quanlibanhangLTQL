using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLLTQL.Models
{
    [Table("Khachhang")]
    public class Khachhang
    {
        [Key] 
        public int Stt { get; set; }
        public string Makhachhang { get; set; }
        public string Tenkhachhang { get; set; }
        public int Sdt { get; set; }
        public string Diachi { get; set; }
    }
}
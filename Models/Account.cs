using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTLLTQL.Models
{
    public class Account
    {
        [Key]
        public string nameID { get; set; }
        public string password { get; set; }

    }
}
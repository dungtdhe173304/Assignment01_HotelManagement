﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThieuDucDungWPF.Model
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        public string CustomerFullName { get; set; }
        public string Telephone { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CustomerBirthday { get; set; }
        public byte CustomerStatus { get; set; }
        public string Password { get; set; }
    }
}

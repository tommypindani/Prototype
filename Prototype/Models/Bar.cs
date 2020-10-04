﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Bar
    { 
        [Key]
        public int Id { get; set; }
        public string Day { get; set; }
        public int year { get; set; }
    }
}

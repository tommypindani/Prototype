using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Pie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
    }
}

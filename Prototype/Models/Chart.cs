using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Chart
    {
        [Key]
        public int Id { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
    }
}

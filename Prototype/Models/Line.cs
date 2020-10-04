using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Line
    {
        [Key]
        public int Id { get; set; }
        public string Country { get; set; }
        public int Hydro { get; set; }
        public int Oil { get; set; }
        public int Gas { get; set; }
        public int Coal { get; set; }
        public int Neclear { get; set; }
    }
}

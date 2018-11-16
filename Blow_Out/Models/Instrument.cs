using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blow_Out.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        public int InstrumentID { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int? CustomerID { get; set; }
    }
}
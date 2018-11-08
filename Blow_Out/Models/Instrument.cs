using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blow_Out.Models
{
    public class Instrument
    {
        public string name { get; set; }
        public float priceNew { get; set; }
        public float priceOld { get; set; }
        public string image { get; set; }
    }
}
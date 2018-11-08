using Blow_Out.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blow_Out.ViewModels
{
    public class InstrumentView
    {
        public List<Instrument> instruments = new List<Instrument>();
        public int instrumentId { get; set; }
    }
}
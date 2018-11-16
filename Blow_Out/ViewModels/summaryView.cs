using Blow_Out.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blow_Out.ViewModels
{
    public class SummaryView
    {
        public Instrument Instrument { get; set; }
        public Customer Customer { get; set; }
    }
}
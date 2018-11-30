using Blow_Out.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blow_Out.ViewModels
{
    public class UpdateDataView
    {
        public List<Customer> customers { get; set; }
        public List<Instrument> instruments { get; set; }
    }
}
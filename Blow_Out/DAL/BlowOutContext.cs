using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Blow_Out.Models;

namespace Blow_Out.DAL
{
    public class BlowOutContext : DbContext
    {
        public BlowOutContext() : base("BlowOutContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
    }
}
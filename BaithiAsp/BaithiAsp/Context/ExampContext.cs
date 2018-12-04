using BaithiAsp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaithiAsp.Context
{
    public class ExampContext : DbContext
    {
        public DbSet<Examp> Examps { get; set; }
    }
}
using _460HW5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _460HW5.DAL
{
    public class WOUContext : DbContext
    {
        public DbSet<WOUForm> WOUForms { get; set; }
    }
}

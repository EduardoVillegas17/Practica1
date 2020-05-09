using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class EventDbContext : DbContext
    {
        public EventDbContext() : base("DefaultConnection") { }

        public DbSet<Ciudad> Ciudads { get; set; }
        public DbSet<Evento> Eventoes { get; set; }
        
    }
    
}
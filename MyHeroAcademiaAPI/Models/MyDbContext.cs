using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyHeroAcademiaAPI.Models;
using System.Data.Entity;

namespace MyHeroAcademiaAPI.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Villain> Villains { get; set; }
    }
}
using CampCamp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CampCamp.Web.DataContexts
{
    public class CampDb : DbContext
    {
        public CampDb()
            : base("DefaultConnection")
        {
        }

        public DbSet<Camp> Camps { get; set; }
    }
}
using bossio_juancruz_lppa_recuperatorio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace bossio_juancruz_lppa_recuperatorio.Data
{
    public class AfiliadoDbContext: DbContext
    {
        public AfiliadoDbContext()
        : base("DefaultConnection")
        {
        }
        public DbSet<Afiliado> Afiliados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
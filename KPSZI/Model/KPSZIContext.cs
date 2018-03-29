using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPSZI.Model
{
    public class KPSZIContext : DbContext
    {
        public KPSZIContext() : base("DbConnection") { }

        public DbSet<Threat> Threats { get; set; }
        public DbSet<ThreatSource> ThreatSources { get; set; }
        public DbSet<IntruderType> IntruderTypes { get; set; }
        public DbSet<InfoType> InfoTypes { get; set; }
        public DbSet<SFH> SFHs { get; set; }
        public DbSet<SFHType> SFHTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema("dimov");
            base.OnModelCreating(builder);
        }
    }
}

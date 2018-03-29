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
        public DbSet<GISMeasure> GisMeasures { get; set; }
        public DbSet<ISPDNMeasure> ISPDNMeasures { get; set; }
        public DbSet<MeasureGroup> MeasureGroups { get; set; }
        public DbSet<SZI> SZIs{ get; set; }
        public DbSet<SZIType> SZITypes { get; set; }
        public DbSet<TCUIThreat> TCUIThreats { get; set; }
        public DbSet<TCUIType> TCUITypes { get; set; }
        public DbSet<TechnogenicMeasure> TechnogenicMeasures { get; set; }
        public DbSet<TechnogenicThreat> TechnogenicThreats { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema("public");
            base.OnModelCreating(builder);
        }
    }
}

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
            builder.HasDefaultSchema("nak");
            base.OnModelCreating(builder);
        }

        static void Seed(KPSZIContext context)
        {
            //base.Seed(context);

            SFHType sfh1 = new SFHType();
                sfh1.Name = "По структуре ИС";
                sfh1.SFHs.Add(new SFH { Name = "Автономное автоматизированное рабочее место", ProjectSecurity = 2 });
                sfh1.SFHs.Add(new SFH { Name = "Локальная ИС", ProjectSecurity = 1 });
                sfh1.SFHs.Add(new SFH { Name = "Распределенная ИС", ProjectSecurity = 0 });

            context.SFHTypes.Add(sfh1);
            context.SaveChanges();
        }
    } 
}

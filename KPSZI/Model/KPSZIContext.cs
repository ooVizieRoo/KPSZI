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
            builder.HasDefaultSchema("soooqa");
            base.OnModelCreating(builder);
        }

        static void Seed(KPSZIContext context)
        {
            //base.Seed(context);

            //Заполнение данных в таблицы

            #region Структурно-функциональные характеристики 
            SFHType sfh1 = new SFHType();
            sfh1.Name = "По структуре ИС";
            sfh1.SFHs.Add(new SFH { Name = "Автономное автоматизированное рабочее место", ProjectSecurity = 2 });
            sfh1.SFHs.Add(new SFH { Name = "Локальная ИС", ProjectSecurity = 1 });
            sfh1.SFHs.Add(new SFH { Name = "Распределенная ИС", ProjectSecurity = 0 });

            SFHType sfh2 = new SFHType();
            sfh2.Name = "По используемым информационным технологиям";
            sfh2.SFHs.Add(new SFH { Name = "Системы на основе виртуализации", ProjectSecurity = 0 });
            sfh2.SFHs.Add(new SFH { Name = "Системы, реализущие \"облачные вычисления\"", ProjectSecurity = 0 });
            sfh2.SFHs.Add(new SFH { Name = "Системы с мобильными устройствами", ProjectSecurity = 0 });
            sfh2.SFHs.Add(new SFH { Name = "Системы с технологиями беспроводного доступа", ProjectSecurity = 0 });
            sfh2.SFHs.Add(new SFH { Name = "Грид-системы", ProjectSecurity = 0 });
            sfh2.SFHs.Add(new SFH { Name = "Суперкомпьютерные системы", ProjectSecurity = 1 });

            SFHType sfh3 = new SFHType();
            sfh3.Name = "По архитектуре информационной системы";
            sfh3.SFHs.Add(new SFH { Name = "Системы на основе \"тонкого клиента\"", ProjectSecurity = 2 });
            sfh3.SFHs.Add(new SFH { Name = "Системы на основе одноранговой сети", ProjectSecurity = 1 });
            sfh3.SFHs.Add(new SFH { Name = "Файл-серверные системы", ProjectSecurity = 0 });
            sfh3.SFHs.Add(new SFH { Name = "Центры обработки данных", ProjectSecurity = 0 });
            sfh3.SFHs.Add(new SFH { Name = "Системы с удаленным доступом пользователей", ProjectSecurity = 0 });
            sfh3.SFHs.Add(new SFH { Name = "Использование разных типов операционных систем (гетерогенность среды)", ProjectSecurity = 1});
            sfh3.SFHs.Add(new SFH { Name = "Использование прикладных программ, независимых от операционных систем", ProjectSecurity = 1});
            sfh3.SFHs.Add(new SFH { Name = "Использование выделенных каналов связи", ProjectSecurity = 1});

            SFHType sfh4 = new SFHType();
            sfh4.Name = "По наличию (отсутствию) взаимосвязей с иными информационными системами";
            sfh4.SFHs.Add(new SFH { Name = "Взаимодействующая с системами", ProjectSecurity = 0 });
            sfh4.SFHs.Add(new SFH { Name = "Невзаимодействующая с системами", ProjectSecurity = 1 });

            SFHType sfh5 = new SFHType();
            sfh5.Name = "По наличию (отсутствию) взаимосвязей (подключений)";
            sfh5.SFHs.Add(new SFH { Name = "Подключенная к сетям связи общего пользования", ProjectSecurity = 0 });
            sfh5.SFHs.Add(new SFH { Name = "Подключенная через выделенную инфрастркутуру (gov.ru ил иную)", ProjectSecurity = 1 });
            sfh5.SFHs.Add(new SFH { Name = "Неподключенная", ProjectSecurity = 2 });

            SFHType sfh6 = new SFHType();
            sfh6.Name = "По размещению технических средств";
            sfh6.SFHs.Add(new SFH { Name = "Расположенные в пределах одной контролируемой зоны", ProjectSecurity = 2 });
            sfh6.SFHs.Add(new SFH { Name = "Расположенные в пределах нескольких контролируемых зон", ProjectSecurity = 1 });
            sfh6.SFHs.Add(new SFH { Name = "Расположенные вне контролируемой зоны", ProjectSecurity = 0 });

            SFHType sfh7 = new SFHType();
            sfh7.Name = "По режимам обработки информации в ИС";
            sfh7.SFHs.Add(new SFH { Name = "Многопользовательский", ProjectSecurity = 0 });
            sfh7.SFHs.Add(new SFH { Name = "Однопользовательский", ProjectSecurity = 2 });

            SFHType sfh8 = new SFHType();
            sfh8.Name = "По режимам разграничения прав доступа";
            sfh8.SFHs.Add(new SFH { Name = "Без разграничения", ProjectSecurity = 0 });
            sfh8.SFHs.Add(new SFH { Name = "С разграничением", ProjectSecurity = 1 });

            SFHType sfh9 = new SFHType();
            sfh9.Name = "По режимам разделения функций по управлению информационной системой";
            sfh9.SFHs.Add(new SFH { Name = "Без разделения", ProjectSecurity = 0 });
            sfh9.SFHs.Add(new SFH { Name = "Выделение рабочих мест для администрирования в отдельный домен", ProjectSecurity = 1 });
            sfh9.SFHs.Add(new SFH { Name = "Использование различных сетевых адресов", ProjectSecurity = 1 });
            sfh9.SFHs.Add(new SFH { Name = "Использование выделенных каналов для администрирования", ProjectSecurity = 1 });

            SFHType sfh10 = new SFHType();
            sfh10.Name = "По подходам к сегментированию";
            sfh10.SFHs.Add(new SFH { Name = "Без сегментирования", ProjectSecurity = 0});
            sfh10.SFHs.Add(new SFH { Name = "С сегментированием", ProjectSecurity = 1 });

            context.SFHTypes.AddRange(new List<SFHType> { sfh1, sfh2, sfh3, sfh4, sfh5, sfh6, sfh7, sfh8, sfh9, sfh10 });

            #endregion


            #region Виды обрабатываемой информации
            InfoType it1 = new InfoType();
            it1.TypeName = "Персональные данные";

            InfoType it2 = new InfoType();
            it2.TypeName = "Служебная тайна";

            InfoType it3 = new InfoType();
            it3.TypeName = "Коммерческая тайна";

            context.InfoTypes.AddRange(new List<InfoType> { it1, it2, it3 });
            #endregion

            context.SaveChanges();
        }
    } 
}

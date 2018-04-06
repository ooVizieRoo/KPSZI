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
        public DbSet<TCUI> TCUIs { get; set; }
        public DbSet<TCUIThreat> TCUIThreats { get; set; }
        public DbSet<TCUIType> TCUITypes { get; set; }
        public DbSet<TechnogenicMeasure> TechnogenicMeasures { get; set; }
        public DbSet<TechnogenicThreat> TechnogenicThreats { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.HasDefaultSchema("dimov");
            base.OnModelCreating(builder);
        }

        public static void Seed(KPSZIContext context)
        {
            #region Меры от НСД для ГИС
            MeasureGroup iaf = new MeasureGroup();
            iaf.Name = "Идентификация и аутентификация субъектов доступа и объектов доступа";
            iaf.ShortName = "ИАФ";
            iaf.Description = "";
            iaf.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Идентификация и аутентификация пользователей, являющихся работниками оператора", MinimalRequirementDefenceClass = 3 });
            iaf.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Идентификация и аутентификация устройств, в том числе стационарных, мобильных и портативных", MinimalRequirementDefenceClass = 2 });
            iaf.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Управление идентификаторами, в том числе создание, присвоение, уничтожение идентификаторов", MinimalRequirementDefenceClass = 3 });
            iaf.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Управление средствами аутентификации, в том числе хранение, выдача, инициализация, блокирование средств аутентификации и принятие мер в случае утраты и(или) компрометации средств аутентификации", MinimalRequirementDefenceClass = 3 });
            iaf.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Защита обратной связи при вводе аутентификационной информации", MinimalRequirementDefenceClass = 3 });
            iaf.GISMeasures.Add(new GISMeasure { Number = 6, Description = "Идентификация и аутентификация пользователей, не являющихся работниками оператора (внешних пользователей)", MinimalRequirementDefenceClass = 3 });
            iaf.GISMeasures.Add(new GISMeasure { Number = 7, Description = "Идентификация и аутентификация объектов файловой системы, запускаемых и исполняемых модулей, объектов систем управления базами данных, объектов, создаваемых прикладным и специальным программным обеспечением, иных объектов доступа", MinimalRequirementDefenceClass = 0 });

            MeasureGroup upd = new MeasureGroup();
            upd.Name = "Управление доступом субъектов доступа к объектам доступа";
            upd.ShortName = "УПД";
            upd.Description = "";
            upd.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Управление (заведение, активация, блокирование и уничтожение) учетными записями пользователей, в том числе внешних пользователей", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Реализация необходимых методов (дискреционный, мандатный, ролевой или иной метод), типов(чтение, запись, выполнение или иной тип) и правил разграничения доступа", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Управление (фильтрация, маршрутизация, контроль соединений, однонаправленная передача и иные способы управления) информационными потоками между устройствами, сегментами информационной системы, а также между информационными системами", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Разделение полномочий (ролей) пользователей, администраторов и лиц, обеспечивающих функционирование информационной системы", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Назначение минимально необходимых прав и привилегий пользователям, администраторам и лицам, обеспечивающим функционирование информационной системы", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 6, Description = "Ограничение неуспешных попыток входа в информационную систему(доступа к информационной системе)", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 7, Description = "Предупреждение пользователя при его входе в информационную систему о том, что в информационной системе реализованы меры защиты информации, и о необходимости соблюдения им установленных оператором правил обработки информации", MinimalRequirementDefenceClass = 0 });
            upd.GISMeasures.Add(new GISMeasure { Number = 8, Description = "Оповещение пользователя после успешного входа в информационную систему о его предыдущем входе в информационную систему", MinimalRequirementDefenceClass = 0 });
            upd.GISMeasures.Add(new GISMeasure { Number = 9, Description = "Ограничение числа параллельных сеансов доступа для каждой учетной записи пользователя информационной системы", MinimalRequirementDefenceClass = 1 });
            upd.GISMeasures.Add(new GISMeasure { Number = 10, Description = "Блокирование сеанса доступа в информационную систему после установленного времени бездействия (неактивности) пользователя или по его запросу", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 11, Description = "Разрешение (запрет) действий пользователей, разрешенных до идентификации и аутентификации", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 12, Description = "Поддержка и сохранение атрибутов безопасности (меток безопасности), связанных с информацией в процессе ее хранения и обработки", MinimalRequirementDefenceClass = 0 });
            upd.GISMeasures.Add(new GISMeasure { Number = 13, Description = "Реализация защищенного удаленного доступа субъектов доступа к объектам доступа через внешние информационно - телекоммуникационные сети", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 14, Description = "Регламентация и контроль использования в информационной системе технологий беспроводного доступа", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 15, Description = "Регламентация и контроль использования в информационной системе мобильных технических средств", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 16, Description = "Управление взаимодействием с информационными системами сторонних организаций(внешние информационные системы)", MinimalRequirementDefenceClass = 3 });
            upd.GISMeasures.Add(new GISMeasure { Number = 17, Description = "Обеспечение доверенной загрузки средств вычислительной техники", MinimalRequirementDefenceClass = 2 });

            MeasureGroup ops = new MeasureGroup();
            ops.Name = "Ограничение программной среды";
            ops.ShortName = "ОПС";
            ops.Description = "";
            ops.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Управление запуском (обращениями) компонентов программного обеспечения, в том числе определение запускаемых компонентов, настройка параметров запуска компонентов, контроль за запуском компонентов программного обеспечения", MinimalRequirementDefenceClass = 1 });
            ops.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Управление установкой (инсталляцией) компонентов программного обеспечения, в том числе определение компонентов, подлежащих установке, настройка параметров установки компонентов, контроль за установкой компонентов программного обеспечения", MinimalRequirementDefenceClass = 2 });
            ops.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Установка (инсталляция) только разрешенного к использованию программного обеспечения и(или) его компонентов", MinimalRequirementDefenceClass = 3 });
            ops.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Управление временными файлами, в том числе запрет, разрешение, перенаправление записи, удаление временных файлов", MinimalRequirementDefenceClass = 0 });

            MeasureGroup zni = new MeasureGroup();
            zni.Name = "Защита машинных носителей информации";
            zni.ShortName = "ЗНИ";
            zni.Description = "";
            zni.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Учет машинных носителей информации", MinimalRequirementDefenceClass = 3 });
            zni.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Управление доступом к машинным носителям информации", MinimalRequirementDefenceClass = 3 });
            zni.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Контроль перемещения машинных носителей информации за пределы контролируемой зоны", MinimalRequirementDefenceClass = 0 });
            zni.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Исключение возможности несанкционированного ознакомления с содержанием информации, хранящейся на машинных носителях, и(или) использования носителей информации в иных информационных системах", MinimalRequirementDefenceClass = 0 });
            zni.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Контроль использования интерфейсов ввода (вывода) информации на машинные носители информации", MinimalRequirementDefenceClass = 2 });
            zni.GISMeasures.Add(new GISMeasure { Number = 6, Description = "Контроль ввода (вывода) информации на машинные носители информации", MinimalRequirementDefenceClass = 0 });
            zni.GISMeasures.Add(new GISMeasure { Number = 7, Description = "Контроль подключения машинных носителей информации", MinimalRequirementDefenceClass = 0 });
            zni.GISMeasures.Add(new GISMeasure { Number = 8, Description = "Уничтожение (стирание) информации на машинных носителях при их передаче между пользователями, в сторонние организации для ремонта или утилизации, а также контроль уничтожения(стирания)", MinimalRequirementDefenceClass = 3 });

            MeasureGroup rsb = new MeasureGroup();
            rsb.Name = "Регистрация событий безопасности";
            rsb.ShortName = "РСБ";
            rsb.Description = "";
            rsb.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Определение событий безопасности, подлежащих регистрации, и сроков их хранения", MinimalRequirementDefenceClass = 3 });
            rsb.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Определение состава и содержания информации о событиях безопасности, подлежащих регистрации", MinimalRequirementDefenceClass = 3 });
            rsb.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Сбор, запись и хранение информации о событиях безопасности в течение установленного времени хранения", MinimalRequirementDefenceClass = 3 });
            rsb.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Реагирование на сбои при регистрации событий безопасности, в том числе аппаратные и программные ошибки, сбои в механизмах сбора информации и достижение предела или переполнения объема (емкости) памяти", MinimalRequirementDefenceClass = 3 });
            rsb.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Мониторинг (просмотр, анализ) результатов регистрации событий безопасности и реагирование на них", MinimalRequirementDefenceClass = 3 });
            rsb.GISMeasures.Add(new GISMeasure { Number = 6, Description = "Генерирование временных меток и (или) синхронизация системного времени в информационной системе", MinimalRequirementDefenceClass = 3 });
            rsb.GISMeasures.Add(new GISMeasure { Number = 7, Description = "Защита информации о событиях безопасности", MinimalRequirementDefenceClass = 3 });
            rsb.GISMeasures.Add(new GISMeasure { Number = 8, Description = "Обеспечение возможности просмотра и анализа информации о действиях отдельных пользователей в информационной системе", MinimalRequirementDefenceClass = 0 });

            MeasureGroup avz = new MeasureGroup();
            avz.Name = "Антивирусная защита";
            avz.ShortName = "АВЗ";
            avz.Description = "";
            avz.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Реализация антивирусной защиты", MinimalRequirementDefenceClass = 3 });
            avz.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Обновление базы данных признаков вредоносных компьютерных программ (вирусов)", MinimalRequirementDefenceClass = 3 });

            MeasureGroup sov = new MeasureGroup();
            sov.Name = "Обнаружение вторжений";
            sov.ShortName = "СОВ";
            sov.Description = "";
            sov.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Обнаружение вторжений", MinimalRequirementDefenceClass = 2 });
            sov.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Обновление базы решающих правил", MinimalRequirementDefenceClass = 2 });

            MeasureGroup anz = new MeasureGroup();
            anz.Name = "Контроль (анализ) защищенности информации";
            anz.ShortName = "АНЗ";
            anz.Description = "";
            anz.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Выявление, анализ уязвимостей информационной системы и оперативное устранение вновь выявленных уязвимостей", MinimalRequirementDefenceClass = 3 });
            anz.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Контроль установки обновлений программного обеспечения, включая обновление программного обеспечения средств защиты информации", MinimalRequirementDefenceClass = 3 });
            anz.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Контроль работоспособности, параметров настройки и правильности функционирования программного обеспечения и средств защиты информации", MinimalRequirementDefenceClass = 3 });
            anz.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Контроль состава технических средств, программного обеспечения и средств защиты информации", MinimalRequirementDefenceClass = 3 });
            anz.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Контроль правил генерации и смены паролей пользователей, заведения и удаления учетных записей пользователей, реализации правил разграничения доступом, полномочий пользователей в информационной системе", MinimalRequirementDefenceClass = 3 });

            MeasureGroup ocl = new MeasureGroup();
            ocl.Name = "Обеспечение целостности информационной системы и информации";
            ocl.ShortName = "ОЦЛ";
            ocl.Description = "";
            ocl.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Контроль целостности программного обеспечения, включая программное обеспечение средств защиты информации", MinimalRequirementDefenceClass = 2 });
            ocl.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Контроль целостности информации, содержащейся в базах данных информационной системы", MinimalRequirementDefenceClass = 0 });
            ocl.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Обеспечение возможности восстановления программного обеспечения, включая программное обеспечение средств защиты информации, при возникновении нештатных ситуаций", MinimalRequirementDefenceClass = 3 });
            ocl.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Обнаружение и реагирование на поступление в информационную систему незапрашиваемых электронных сообщений(писем, документов) и иной информации, не относящихся к функционированию информационной системы(защита от спама)", MinimalRequirementDefenceClass = 2 });
            ocl.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Контроль содержания информации, передаваемой из информационной системы (контейнерный, основанный на свойствах объекта доступа, и контентный, основанный на поиске запрещенной к передаче информации с использованием сигнатур, масок и иных методов), и исключение неправомерной передачи информации из информационной системы", MinimalRequirementDefenceClass = 0 });
            ocl.GISMeasures.Add(new GISMeasure { Number = 6, Description = "Ограничение прав пользователей по вводу информации в информационную систему", MinimalRequirementDefenceClass = 1 });
            ocl.GISMeasures.Add(new GISMeasure { Number = 7, Description = "Контроль точности, полноты и правильности данных, вводимых в информационную систему", MinimalRequirementDefenceClass = 0 });
            ocl.GISMeasures.Add(new GISMeasure { Number = 8, Description = "Контроль ошибочных действий пользователей по вводу и(или) передаче информации и предупреждение пользователей об ошибочных действиях", MinimalRequirementDefenceClass = 0 });

            MeasureGroup odt = new MeasureGroup();
            odt.Name = "Обеспечение доступности информации";
            odt.ShortName = "ОДТ";
            odt.Description = "";
            odt.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Использование отказоустойчивых технических средств", MinimalRequirementDefenceClass = 1 });
            odt.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Резервирование технических средств, программного обеспечения, каналов передачи информации, средств обеспечения функционирования информационной системы", MinimalRequirementDefenceClass = 1 });
            odt.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Контроль безотказного функционирования технических средств, обнаружение и локализация отказов функционирования, принятие мер по восстановлению отказавших средств и их тестирование", MinimalRequirementDefenceClass = 2 });
            odt.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Периодическое резервное копирование информации на резервные машинные носители информации", MinimalRequirementDefenceClass = 2 });
            odt.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Обеспечение возможности восстановления информации с резервных машинных носителей информации(резервных копий) в течение установленного временного интервала", MinimalRequirementDefenceClass = 2 });
            odt.GISMeasures.Add(new GISMeasure { Number = 6, Description = "Кластеризация информационной системы и (или) ее сегментов", MinimalRequirementDefenceClass = 0 });
            odt.GISMeasures.Add(new GISMeasure { Number = 7, Description = "Контроль состояния и качества предоставления уполномоченным лицом вычислительных ресурсов (мощностей), в том числе по передаче информации", MinimalRequirementDefenceClass = 2 });

            MeasureGroup zsv = new MeasureGroup();
            zsv.Name = "Защита среды виртуализации";
            zsv.ShortName = "ЗСВ";
            zsv.Description = "";
            zsv.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Идентификация и аутентификация субъектов доступа и объектов доступа в виртуальной инфраструктуре, в том числе администраторов управления средствами виртуализации", MinimalRequirementDefenceClass = 3 });
            zsv.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Управление доступом субъектов доступа к объектам доступа в виртуальной инфраструктуре, в том числе внутри виртуальных машин", MinimalRequirementDefenceClass = 3 });
            zsv.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Регистрация событий безопасности в виртуальной инфраструктуре", MinimalRequirementDefenceClass = 3 });
            zsv.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Управление (фильтрация, маршрутизация, контроль соединения, однонаправленная передача) потоками информации между компонентами виртуальной инфраструктуры, а также по периметру виртуальной инфраструктуры", MinimalRequirementDefenceClass = 2 });
            zsv.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Доверенная загрузка серверов виртуализации, виртуальной машины(контейнера), серверов управления виртуализацией", MinimalRequirementDefenceClass = 0 });
            zsv.GISMeasures.Add(new GISMeasure { Number = 6, Description = "Управление перемещением виртуальных машин (контейнеров) и обрабатываемых на них данных", MinimalRequirementDefenceClass = 2 });
            zsv.GISMeasures.Add(new GISMeasure { Number = 7, Description = "Контроль целостности виртуальной инфраструктуры и ее конфигураций", MinimalRequirementDefenceClass = 2 });
            zsv.GISMeasures.Add(new GISMeasure { Number = 8, Description = "Резервное копирование данных, резервирование технических средств, программного обеспечения виртуальной инфраструктуры, а также каналов связивнутри виртуальной инфраструктуры", MinimalRequirementDefenceClass = 2 });
            zsv.GISMeasures.Add(new GISMeasure { Number = 9, Description = "Реализация и управление антивирусной защитой в виртуальной инфраструктуре", MinimalRequirementDefenceClass = 3 });
            zsv.GISMeasures.Add(new GISMeasure { Number = 10, Description = "Разбиение виртуальной инфраструктуры на сегменты(сегментирование виртуальной инфраструктуры) для обработки информации отдельным пользователем и(или) группой пользователей", MinimalRequirementDefenceClass = 3 });

            MeasureGroup zts = new MeasureGroup();
            zts.Name = "Защита технических средств";
            zts.ShortName = "ЗТС";
            zts.Description = "";
            zts.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Защита информации, обрабатываемой техническими средствами, от ее утечки по техническим каналам", MinimalRequirementDefenceClass = 0 });
            zts.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Организация контролируемой зоны, в пределах которой постоянно размещаются стационарные технические средства, обрабатывающие информацию, и средства защиты информации, а также средства обеспечения функционирования", MinimalRequirementDefenceClass = 3 });
            zts.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Контроль и управление физическим доступом к техническим средствам, средствам защиты информации, средствам обеспечения функционирования, а также в помещения и сооружения, в которых они установлены, исключающие несанкционированный физический доступ к средствам обработки информации, средствам защиты информации и средствам обеспечения функционирования информационной системы и помещения и сооружения, в которых они установлены", MinimalRequirementDefenceClass = 3 });
            zts.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Размещение устройств вывода (отображения) информации, исключающее ее несанкционированный просмотр", MinimalRequirementDefenceClass = 3 });
            zts.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Защита от внешних воздействий (воздействий окружающей среды, нестабильности электроснабжения, кондиционирования и иных внешних факторов)", MinimalRequirementDefenceClass = 1 });

            MeasureGroup zis = new MeasureGroup();
            zis.Name = "Защита информационной системы, ее средств, систем связи и передачи данных";
            zis.ShortName = "ЗИС";
            zis.Description = "";
            zis.GISMeasures.Add(new GISMeasure { Number = 1, Description = "Разделение в информационной системе функций поvуправлению(администрированию) информационной системой, управлению(администрированию) системой защиты информации, функций по обработке информации и иных функций информационной системы", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 2, Description = "Предотвращение задержки или прерывания выполнения процессов с высоким приоритетом со стороны процессов с низким приоритетом", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 3, Description = "Обеспечение защиты информации от раскрытия, модификации и навязывания(ввода ложной информации) при ее передаче(подготовке к передаче) по каналам связи, имеющим выход за пределы контролируемой зоны, в том числе беспроводным каналам связи", MinimalRequirementDefenceClass = 3 });
            zis.GISMeasures.Add(new GISMeasure { Number = 4, Description = "Обеспечение доверенных канала, маршрута между администратором, пользователем и средствами защиты информации(функциями безопасности средств защиты информации)", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 5, Description = "Запрет несанкционированной удаленной активации видеокамер, микрофонов и иных периферийных устройств, которые могут активироваться удаленно, и оповещение пользователей об активации таких устройств", MinimalRequirementDefenceClass = 3 });
            zis.GISMeasures.Add(new GISMeasure { Number = 6, Description = "Передача и контроль целостности атрибутов безопасности(меток безопасности), связанных с информацией, при обмене информацией с иными информационными системами", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 7, Description = "Контроль санкционированного и исключение несанкционированного использования технологий мобильного кода, в том числе регистрация событий, связанных с использованием технологий мобильного кода, их анализ и реагирование на нарушения, связанные с использованием технологий мобильного кода", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 8, Description = "Контроль санкционированного и исключение несанкционированного использования технологий передачи речи, в том числе регистрация событий, связанных с использованием технологий передачи речи, их анализ и реагирование на нарушения, связанные с использованием технологий передачи речи", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 9, Description = "Контроль санкционированной и исключение несанкционированной передачи видеоинформации, в том числе регистрация событий, связанных с передачей видеоинформации, их анализ и реагирование на нарушения, связанные с передачей видеоинформации", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 10, Description = "Подтверждение происхождения источника информации, получаемой в процессе определения сетевых адресов по сетевым именам или определения сетевых имен по сетевым адресам", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 11, Description = "Обеспечение подлинности сетевых соединений (сеансов взаимодействия), в том числе для защиты от подмены сетевых устройств и сервисов", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 12, Description = "Исключение возможности отрицания пользователем факта отправки информации другому пользователю", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 13, Description = "Исключение возможности отрицания пользователем факта получения информации от другого пользователя", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 14, Description = "Использование устройств терминального доступа для обработки информации", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 15, Description = "Защита архивных файлов, параметров настройки средств защиты информации и программного обеспечения и иных данных, не подлежащих изменению в процессе обработки информации", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 16, Description = "Выявление, анализ и блокирование в информационной системе скрытых каналов передачи информации в обход реализованных мер защиты информации или внутри разрешенных сетевых протоколов", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 17, Description = "Разбиение информационной системы на сегменты (сегментирование информационной системы) и обеспечение защиты периметров сегментов информационной системы", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 18, Description = "Обеспечение загрузки и исполнения программного обеспечения с машинных носителей информации, доступных только для чтения, и контроль целостности данного программного обеспечения", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 19, Description = "Изоляция процессов (выполнение программ) в выделенной области памяти", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 20, Description = "Защита беспроводных соединений, применяемых в информационной системе", MinimalRequirementDefenceClass = 3 });
            zis.GISMeasures.Add(new GISMeasure { Number = 21, Description = "Исключение доступа пользователя к информации, возникшей в результате действий предыдущего пользователя через реестры, оперативную память, внешние запоминающие устройства и иные общие для пользователей ресурсы информационной системы", MinimalRequirementDefenceClass = 1 });
            zis.GISMeasures.Add(new GISMeasure { Number = 22, Description = "Защита информационной системы от угроз безопасности информации, направленных на отказ в обслуживании информационной системы", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 23, Description = "Защита периметра (физических и (или) логических границ) информационной системы при ее взаимодействии с иными информационными системами и информационнотелекоммуникационными сетями", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 24, Description = "Прекращение сетевых соединений по их завершении или по истечении заданного оператором временного интервала неактивности сетевого соединения", MinimalRequirementDefenceClass = 2 });
            zis.GISMeasures.Add(new GISMeasure { Number = 25, Description = "Использование в информационной системе или ее сегментах различных типов общесистемного, прикладного и специального программного обеспечения(создание гетерогенной среды)", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 26, Description = "Использование прикладного и специального программного обеспечения, имеющих возможность функционирования в средах различных операционных систем", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 27, Description = "Создание (эмуляция) ложных информационных систем или их компонентов, предназначенных для обнаружения, регистрации и анализа действий нарушителей в процессе реализации угроз безопасности информации", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 28, Description = "Воспроизведение ложных и (или) скрытие истинных отдельных информационных технологий и(или) структурно - функциональных характеристик информационной системы или ее сегментов, обеспечивающее навязывание нарушителю ложного представления об истинных информационных технологиях и(или) структурно - функциональных характеристиках информационной системы", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 29, Description = "Перевод информационной системы или ее устройств (компонентов) в заранее определенную конфигурацию, обеспечивающую защиту информации, в случае возникновении отказов(сбоев)", MinimalRequirementDefenceClass = 0 });
            zis.GISMeasures.Add(new GISMeasure { Number = 30, Description = "Защита мобильных технических средств, применяемых в информационной системе", MinimalRequirementDefenceClass = 3 });

            context.MeasureGroups.AddRange(new List<MeasureGroup> { iaf, upd, ops, zni, rsb, avz, sov, anz, ocl, odt, zsv, zts, zis });
            #endregion

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

            InfoType it4 = new InfoType();
            it4.TypeName = "Сведения о сущности изобретения, полезной модели или промышленного образца до официальной публикации информации о них";

            InfoType it5 = new InfoType();
            it5.TypeName = "Тайна следствия и судопроизводства";

            InfoType it6 = new InfoType();
            it6.TypeName = "Профессиональная тайна";

            InfoType it7 = new InfoType();
            it7.TypeName = "Сведения, содержащиеся в личных делах осужденных, а также сведения о принудительном исполнении судебных актов, актов других органов и должностных лиц, кроме сведений, которые являются общедоступными ";


            context.InfoTypes.AddRange(new List<InfoType> { it1, it2, it3 });
            #endregion

            #region ТКУИ (типы, каналы, угрозы)
            
            //ПЭМИН
            TCUIType pemin = new TCUIType{ Name = "Каналы побочных электромагнитных излучений и наводок (ПЭМИН)"};

            TCUI emi = new TCUI { Name = "Электромагнитные" };
            emi.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации за счет побочных электромагнитных излучений (ПЭМИ) ТСПИ, возникающих при прохождении тока по их токоведущим элементам ТСПИ", Identificator = "ТП.001", Description = "Угроза заключается в возможности перехвата нарушителем собственных ПЭМИ ТСПИ, носителем информации в которых является электрический ток, параметры которого изменяются по закону изменения информативного сигнала. При прохождении электрического тока по токопроводящим элементам ТСПИ вокруг них возникает электрическое и магнитное поле; в силу чего элементы ТСПИ рассматриваются как излучатели электромагнитного поля, несущего информацию; реализация данной угрозы возможна в случае наличия у нарушителя технических средств, осуществляющих обнаружение, приём и обработку информативных сигналов, а также  сведений о конфигурации ИС и ТСПИ" });
            emi.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации за счет побочных электромагнитных излучений (ПЭМИ), возникающих на частотах работы высокочастотных генераторов ТСПИ", Identificator = "ТП.002", Description = "Угроза заключается в возможности применения нарушителем высокочастотных генераторов с направленной антенной, осуществляющих взаимодействие с элементами СВТ и обеспечивающих перехват информативного сигнала с использованием приемных устройств средств разведки; угроза обусловлена тем, что СВТ могут быть подвержены мощному высокочастотному облучению. Способ «высокочастотного облучения» заключается в том, что СВТ облучаются мощным высокочастотным гармоническим сигналом (для этих целей используется высокочастотный генератор с направленной антенной, имеющей узкую диаграмму направленности); при взаимодействии облучающего электромагнитного поля с элементами СВТ происходит модуляция вторичного излучения информативным сигналом; переизлучённый сигнал принимается приёмным устройством средства разведки и детектируется" });
            emi.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации за счет побочных электромагнитных излучений (ПЭМИ) на частотах самовозбуждения усилителей низкой частоты ТСПИ", Identificator = "ТП.003", Description = "Самовозбуждение усилителей низкой частоты ТСПИ (систем звукового сопровождения, магнитофонов, систем громкоговорящей связи и т.п) возможно за счет образования случайных паразитных связей, что приводит к переводу усилителя в режим автогенерации сигналов; сигнал на частотах самовозбуждения, как правило, оказывается промодулированным информативным сигналом" });
            emi.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации за счет наводок электромагнитных излучений (ЭМИ)ТСПИ на соединительные линии ВТСС и посторонние проводники, выходящие за пределы КЗ", Identificator = "ТП.004", Description = "угроза заключается в возможности перехвата нарушителем наводок информативных сигналов с инженерных коммуникаций с использованием технических средств разведки ПЭМИН; угроза связана с возникновением наводок информативных сигналов в посторонних проводниках, а также с наличием выхода за пределы контролируемой зоны объектов соединительных линий ВТСС, линий электропитания или посторонних проводников и возможностью непосредственного подключения к ним средств разведки ПЭМИН под информативным сигналом понимаются токи и напряжения в токопроводящих элементах, вызванные побочными электромагнитными излучениями." });

            TCUI electrical = new TCUI { Name = "Электрические" };
            electrical.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информативных сигналов за счет их просачивания в линии электропитания и цепи заземления ТСПИ", Identificator = "ТП.005", Description = "Угроза заключается в возможности создания нарушителем подключений к линиям электропитания и заземления ТСПИ с использованием средств разведки; угроза обусловлена возникновением наводок информативных сигналов в линиях электропитания ТСПИ; в линиях электропитания и соединительных линиях ВТСС; в цепях заземления ТСПИ и ВТСС; реализация данной угрозы возможна в случае наличия у нарушителя возможности подключения технических средств разведки, токосъемных устройств и других технических средств, осуществляющих обнаружение, приём и обработку информативных сигналов к линиям электропитания и заземления, находящимися за пределами КЗ" });


            TCUI parametrical = new TCUI { Name = "Параметрические" };
            parametrical.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации за счет съема информации, обрабатываемой ТСПИ, путем использования закладных устройств", Identificator = "ТП.006", Description = "Угроза заключается в возможности установки нарушителем закладных устройств в ТСПИ, осуществляющих обработку информации. Закладные устройства представляют собой минипередатчики, излучение которых модулируется информативных сигналом. Перехваченная с помощью закладного устройства информация или непосредственно передается по радиоканалу, или сначала записывается на специальное запоминающее устройство, а затем по команде передается на контрольный пункт перехвата" });
            parametrical.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации за счет перехвата информативного сигнала путем «высокочастотного облучения» ТСПИ", Identificator = "ТП.007", Description = "Угроза заключается в возможности перехвата информации за счет взаимодействия облучающего электромагнитного поля с элементами ТСПИ, вызывающего переизлучение электромагнитного поля, такое излучение имеет модуляцию, обусловленную воздействием информативного сигнала; для перехвата информации таким способом нарушителю необходимы специальные высокочастотные генераторы с антеннами, имеющими узкие диаграммы направленности и специальные радиоприемные устройства" });

            pemin.TCUIs.Add(emi);
            pemin.TCUIs.Add(electrical);
            pemin.TCUIs.Add(parametrical);


            // Акустика
            TCUIType aqoost = new TCUIType { Name = "Каналы утечки акустической (речевой) информации" };
            TCUI air = new TCUI { Name = "Воздушные" };
            air.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации за счет распространения информативного акстического сигнала в воздушной среде", Identificator = "ТА.001", Description = "Угроза заключается в возможности перехвата акустического информативного сигнала, средой распространения которого является воздух; для перехвата применяются высокочастотные и специальные направленные микрофоны, соединяющихся с портативными звукозаписывающими устройствами или передатчиками Перехваченная речевая информация может передаваться по радиоканалу, сети электропитания, оптическому каналу, соединительным линиям ВТСС, посторонним проводникам, инженерным коммуникациям в ультразвуковом диапазоне частот, телефонной линии с вызовом от внешнего телефонного абонента." });

            TCUI vibro = new TCUI { Name = "Вибрационные" };
            vibro.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации по виброакустическому каналу за счет распространения информативного сигнала в инженерных коммуникациях (трубы водоснабжения, отопления, вентиляции и т.д) и ограждающих строительных конструкциях (стены, потолки, полы)", Identificator = "ТА.002", Description = "Угроза заключается в возможности использования вибродатчиков (акселерометров) с целью перехвата информативного сигнала за счет его распространения в инженерных коммуникациях и ограждающих строительных конструкциях; вибродатчик, соединенный с электронным усилителем, называется электронным стетоскопом; электронный стетоскоп позволяет осуществлять прослушивание речи с помощью головных телефонов и ее запись на диктофон." });
            vibro.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации по виброакустическому каналу за счет перехвата информативного сигнала с использованием закладных устройств", Identificator = "ТА.003", Description = "Угроза заключается в возможности использования закладных устройств (радиостетоскопов) с целью перехвата информативного сигнала за счет его распространения в инженерных коммуникациях и ограждающих строительных конструкциях; возможно использование закладных устройств с передачей информации по оптическому каналу в ближнем  инфракрасном диапазоне длин волн, а также по ультразвуковому каналу (по инженерным коммуникациям)." });

            TCUI aqoostelect = new TCUI { Name = "Акусто-электрические" };
            aqoostelect.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации по акустоэлектрическому каналу, возникающему за счет акустоэлектрических преобразований («микрофонного эффекта») элементов ВТСС", Identificator = "ТА.004", Description = "Угроза заключается в возможности подключения к соединительным линиям ВТСС высокочувствительных низкочастотных усилителей с целью перехвата акустоэлектрических колебаний; угроза обусловлена возникновением акусто-электрического канала утечки за счет преобразований акустических сигналов в электрические." });
            aqoostelect.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации через ВТСС по акустоэлектрическому каналу, осуществляемому путем «высокочастотного навязывания»", Identificator = "ТА.005", Description = "Технический канал утечки информации с использованием «высокочастотного навязывания» может быть осуществлен путем несанкционированного контактного введения токов высокой частоты от соответствующего генератора в линии, имеющей функциональные связи с нелинейными или параметрическими элементами ВТСС, на которых происходит модуляция высокочастотного сигнала информативным; промодулированный сигнал отражается от указанных элементов и распространяется в обратном направлении по линии или излучается." });

            TCUI opticelect = new TCUI { Name = "Оптико-электронные" };
            opticelect.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки акустической информации по оптико-электронному каналу за счет облучения лазерным лучом отражающих поверхностей (оконные стекла, зеркала и т.д), вибрирующих под действием информативного акустического сигнала", Identificator = "ТА.006", Description = "Угроза заключается в возможности использования лазерных систем («лазерных микрофонов») для перехвата речевой информации. Оптико-электронный канал утечки образуется при облучении лазерным лучом отражающих поверхностей. При большом расстоянии до отражающих поверхностей для организации такого канала используется зеркальное отражение лазерного луча при небольших расстояниях (порядка нескольких десятков метров) может быть использовано диффузное отражение лазерного излучения." });

            TCUI paramair = new TCUI { Name = "Параметрические" };
            paramair.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки акустической информации по параметрическому каналу, образованному за счет «высокочастотного облучения» помещения, где установлены закладные устройства, имеющие элементы, параметры которых изменяются под действием акустического сигнала", Identificator = "ТА.007", Description = "Угроза заключается в возможности реализации «высокочастотного облучения» помещения с установленными закладными устройствами, в результате которого в этих закладных устройствах при взаимодействии облучающего электромагнитного поля со специальными элементами закладки происходит образование вторичных радиоволн, т.е переизлучение электромагнитного поля. Специальное устройство закладки обеспечивает амплитудную, фазовую или частотную модуляцию переотраженного сигнала по закону изменения речевого сигнала." });
            paramair.TCUIThreats.Add(new TCUIThreat { Name = "Угроза перехвата акустической информации по параметрическому каналу путем приема модулированных информативных сигналов побочных электромагнитных излучений (ПЭМИ) ТСПИ и ВТСС", Identificator = "ТА.008", Description = "Угроза обусловлена тем, что в результате воздействия акустического поля меняется давление на все элементы высокочастотных генераторов ТСПИ и ВТСС. При этом изменяется взаимное расположение элементов схем, проводов в катушках индуктивности, что может привести к изменениям параметров высокочастотного сигнала, например, к модуляции его информативным сигналом." });

            aqoost.TCUIs.Add(air);
            aqoost.TCUIs.Add(vibro);
            aqoost.TCUIs.Add(aqoostelect);
            aqoost.TCUIs.Add(opticelect);
            aqoost.TCUIs.Add(paramair);

            // Перехват информации при передаче по каналам связи
            TCUIType perehvat = new TCUIType { Name = "Каналы перехвата информации при ее передаче по каналам связи" };
            TCUI emi_per = new TCUI { Name = "Электромагнитные" };
            emi_per.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации по электромагнитному каналу с использованием портативных средств радиоразведки", Identificator = "ТС.001", Description = " Угроза заключается в возможности перехвата электромагнитных излучений передатчиков средств связи, модулированных информационным сигналом с использованием средств радиоразведки. Данный канал утечки широко используется для прослушивания телефонных разговоров, ведущихся по радиорелейным, сотовым телефонам или по радиорелейным и спутниковым линиям связи" });

            TCUI elect_per = new TCUI { Name = "Электрические" };
            elect_per.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации, передаваемой по кабельным линиям связи путем контактного подключения к ним аппаратуры перехвата", Identificator = "ТС.002", Description = "Угроза заключается в возможности подключения аппаратуры перехвата к кабельным линиям связи с целью перехвата информации, передаваемой по этим линиям. Средства перехвата подключаются к линии связи или через согласующее устройство, незначительно снижающее падение напряжения, или через специальное устройство компенсации падения напряжения. Контактный способ подключения используется в основном для снятия информации с коаксиальных и низкочастотных кабелей связи." });

            TCUI induc_per = new TCUI { Name = "Индукционные" };
            induc_per.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки информации за счет возникновения электромагнитного поля вокруг кабеля связи, по которому проходит информативный электрический сигнал, с использованием специальных индукционных датчиков", Identificator = "ТС.003", Description = "Угроза заключается в возможности применения специальных индукционных датчиков для перехвата информативных электрических сигналов, проходящих в индукционном канале и создающих вокруг кабеля связи электромагнитное поле. Индукционные датчики применяются в основном для съема информации с симметричных высокочастотных кабелей. Для бесконтактного съема информации с незащищенных линий связи могут использоваться специальные высокочувствительные низкочастотные усилители, снабженные магнитными антеннами." });

            perehvat.TCUIs.Add(emi_per);
            perehvat.TCUIs.Add(elect_per);
            perehvat.TCUIs.Add(induc_per);


            // Утечка видовой информации
            TCUIType vid = new TCUIType { Name = "Каналы утечки видовой информации" };
            TCUI vidovoi = new TCUI { Name = "Видовые" };
            vidovoi.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки видовой информации путем наблюдения за объектами с использованием специальных технических средств (оптические приборы, телевизионные камеры, приборы ночного видения и т.д)", Identificator = "ТВ.001", Description = "Угроза связана с возможностью применения технических средств (монокуляров, подзорных труб, биноклей, телескопов, телевизионных камер, приборов ночного видения, телевизионных камер, тепловизоров и т.д) для наблюдения за объектами с целью перехвата и дальнейшего использования видовой информации . Изображение с телевизионных камер может передаваться на мониторы как по кабелю, так и по радиоканалу." });
            vidovoi.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки видовой информации путем съемки объектов с использованием телевизионных и фотографических средств", Identificator = "ТВ.002", Description = "Угроза заключается в возможности применения телевизионных и фотографических средств (портативных камуфлированных фотоаппаратов, телевизионных камер с длиннофокусными объективами или совмещенными с телескопами) для съемки объектов с целью съемки объектов для дальнейшего документирования результатов наблюдения и более подробного изучения объектов." });
            vidovoi.TCUIThreats.Add(new TCUIThreat { Name = "Угроза утечки видовой информации путем съемки документов с использованием портативных фотоаппаратов", Identificator = "ТВ.003", Description = "Угроза заключается в возможности применения портативных фотоаппаратов. (портативных камуфлированных фотоаппаратов, телевизионных камер с длиннофокусными объективами или совмещенными с телескопами) для съемки документов, содержащих конфиденциальную информацию." });

            vid.TCUIs.Add(vidovoi);
            context.TCUITypes.AddRange(new List<TCUIType> { vid, aqoost, pemin, perehvat });
            #endregion

            context.SaveChanges();
        }
    } 
}

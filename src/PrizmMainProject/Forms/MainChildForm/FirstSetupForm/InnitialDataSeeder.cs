using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public class InnitialDataSeeder : IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(InnitialDataSeeder));

        private const int HEATCOUNT = 5;
        private const int PIPECOUNT = 1210;
        private const int INSPECTORCOUNT = 25;
        private const int WELDERCOUNT = 25;
        private const int COMPONENTCOUNT = 300;
        private const int RELEASECOUNT = 48;

        IFirstSetupRepo firstSetupRepo;
        FirstSetupViewModel viewModel;

        List<SeamType> seamTypes;
        List<InspectorCertificateType> inspetorCertTypes;
        List<PipeMillSizeType> types;
        List<Category> categories;
        List<PipeTest> tests;

        public InnitialDataSeeder(FirstSetupViewModel vm)
        {
            this.firstSetupRepo = new FirstSetupRepo();
            this.viewModel = vm;
        }

        public bool Seed(bool isOptionalSeed)
        {
            bool req, opt = true;
            req = SeedRequired();
            if(isOptionalSeed)
            {
                opt = SeedOptional();
            }
            return req && opt;
        }
        private Random rnd = new Random();

        private bool SeedRequired()
        {
            firstSetupRepo.BeginTransaction();
            #region SeamTypes
            seamTypes = new List<SeamType>
            {
                new SeamType{Name = "Бесшовный", IsActive = true},
                new SeamType{Name = "Прямой", IsActive = true},
                new SeamType{Name = "Спиралевидный", IsActive = true},
            };
            foreach(var item in seamTypes)
            {
                firstSetupRepo.SeemTypeRepo.Save(item);
            }
            #endregion
            firstSetupRepo.Commit();

            firstSetupRepo.BeginTransaction();
            #region InspectorCertificateTypes
            inspetorCertTypes = new List<InspectorCertificateType>
            {
                new InspectorCertificateType {Name = "Покрытия (Coating)",IsActive = true},
                new InspectorCertificateType {Name = "РК (RT)",IsActive = true},
                new InspectorCertificateType {Name = "ВИК (VT)",IsActive = true},
                new InspectorCertificateType {Name = "УК (UT)",IsActive = true},
                new InspectorCertificateType {Name = "НАКС (Welding Engineer)",IsActive = true},
                new InspectorCertificateType {Name = "МК (MT)",IsActive = true}
            };
            inspetorCertTypes.ForEach(s => firstSetupRepo.CertificateTypeRepo.Save(s));
            #endregion
            firstSetupRepo.Commit();

            firstSetupRepo.BeginTransaction();
            #region PipeMillSyzeType
            types = new List<PipeMillSizeType>
            {
                new PipeMillSizeType
                {
                    Type = "1500 X 100500 X 50 - бесшовный",
                    IsActive = true,
                    Length = 9090,
                    Diameter = 1212,
                    Thickness = 12,
                    SeamType = seamTypes[0]
                },
                new PipeMillSizeType
                {
                    Type = "1500 X 100500 X 50 - Прямой",
                    IsActive = true,
                    Length = 9090,
                    Diameter = 1212,
                    Thickness = 12,
                    SeamType = seamTypes[1]
                },
            };
            types.ForEach(s => firstSetupRepo.SizeTypeRepo.Save(s));
            #endregion
            firstSetupRepo.Commit();

            firstSetupRepo.BeginTransaction();
            #region PipeTestCategory
            categories = new List<Category>
            {
                #region creating pipe test category
                new Category { Name = "Категория - 1", Fixed = false, Type = FixedCategory.Undefined, IsActive = true},
                new Category { Name = "Категория - 2", Fixed = false, Type = FixedCategory.Undefined, IsActive = true},
                new Category { Name = "Измерение длины", IsActive = true , Fixed=true, ResultType="int", Type=FixedCategory.Length},
                new Category { Name = "Контроль сварки", IsActive = true, Fixed = true, ResultType = "int", Type = FixedCategory.Weld },
                new Category { Name = "Контроль внешнего покрытия", IsActive = true, Fixed = true, ResultType = "int", Type = FixedCategory.ExternalCoat },
                new Category { Name = "Контроль внутреннего покрытия", IsActive = true, Fixed = true, ResultType = "int", Type = FixedCategory.InternalCoat }
	            #endregion
            };
            foreach(var category in categories)
            {
                firstSetupRepo.CategoryRepo.Save(category);
            }
            #endregion
            firstSetupRepo.Commit();

            firstSetupRepo.BeginTransaction();
            #region PipeTest
            tests = new List<PipeTest>
            {
                #region creating pipetests for first pipe size type
                new PipeTest 
                {
                    Code = "01",
                    Name = "Входной контроль листа",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "02",
                    Name = "Сварка технологического шва",
                    Category = categories[3],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "03",
                    Name = "Сварка наружного шва",
                    Category = categories[3],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "04",
                    Name = "Сварка внутреннего шва",
                    Category = categories[3],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "05",
                    Name = "Экспандирование",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Review,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "06",
                    Name = "Обработка торцов",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "07",
                    Name = "Гидроиспытание",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "08",
                    Name = "Рентген сварного шва",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.String,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "09",
                    Name = "АУЗК сварного шва",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.String,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "10",
                    Name = "РУЗК концов сварного шва",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.String,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "11",
                    Name = "МПК фаски",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.String,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "12",
                    Name = "Наружный диаметр",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.Diapason,
                    MinExpected = 1217,
                    MaxExpected = 1221,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "13",
                    Name = "Длина трубы",
                    Category = categories[2],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Diapason,
                    MinExpected = 9000,
                    MaxExpected = 12400,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "21",
                    Name = "Нанесение наружного покрытия",
                    Category = categories[4],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "31",
                    Name = "Нанесение внутреннего покрытия",
                    Category = categories[5],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "41",
                    Name = "Складирование",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[0],
                    IsActive = true,
                    IsRequired = true
                }, 
	            #endregion

                #region creating pipetests for second pipe size type
                new PipeTest 
                {
                    Code = "01",
                    Name = "Входной контроль листа",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "02",
                    Name = "Сварка технологического шва",
                    Category = categories[3],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "03",
                    Name = "Сварка наружного шва",
                    Category = categories[3],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "04",
                    Name = "Сварка внутреннего шва",
                    Category = categories[3],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "05",
                    Name = "Экспандирование",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Review,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "06",
                    Name = "Обработка торцов",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "07",
                    Name = "Гидроиспытание",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "08",
                    Name = "Рентген сварного шва",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.String,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "09",
                    Name = "АУЗК сварного шва",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.String,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "10",
                    Name = "РУЗК концов сварного шва",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.String,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "11",
                    Name = "МПК фаски",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.String,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "12",
                    Name = "Наружный диаметр",
                    Category = categories[1],
                    ControlType = PipeTestControlType.Witness,
                    ResultType = PipeTestResultType.Diapason,
                    MinExpected = 1217,
                    MaxExpected = 1221,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "13",
                    Name = "Длина трубы",
                    Category = categories[2],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Diapason,
                    MinExpected = 9000,
                    MaxExpected = 12400,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "21",
                    Name = "Нанесение наружного покрытия",
                    Category = categories[4],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "31",
                    Name = "Нанесение внутреннего покрытия",
                    Category = categories[5],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                },

                new PipeTest 
                {
                    Code = "41",
                    Name = "Складирование",
                    Category = categories[0],
                    ControlType = PipeTestControlType.Monitor,
                    ResultType = PipeTestResultType.Boolean,
                    pipeType = types[1],
                    IsActive = true,
                    IsRequired = true
                } 
	#endregion
            };

            foreach(var test in tests)
            {
                firstSetupRepo.TestRepo.Save(test);
            }
            #endregion
            firstSetupRepo.Commit();

            return false;
        }

        private bool SeedOptional()
        {

            firstSetupRepo.BeginTransaction();
            #region PlateManufacturers
            PlateManufacturer[] plateManufacturers = 
            {
                new PlateManufacturer {Name = "Алапаевский металлургический завод", IsActive = true},
                new PlateManufacturer {Name = "Альметьевский трубный завод", IsActive = true},
                new PlateManufacturer {Name = "Борский трубный завод", IsActive = true},
                new PlateManufacturer {Name = "Волжский трубный завод", IsActive = true},
                new PlateManufacturer {Name = "Волгоградский трубный завод", IsActive = true},
                new PlateManufacturer {Name = "Гурьевский металлургический завод", IsActive = true},
                new PlateManufacturer {Name = "Завод Точлит", IsActive = true}
            };
            Array.ForEach(plateManufacturers, s => firstSetupRepo.PlateManRepo.Save(s));
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region Heat
            List<Heat> heats = new List<Heat>();
            for(int i = 0; i < HEATCOUNT; i++)
            {
                heats.Add
                    (
                    new Heat
                    {
                        Number = RndString(8),
                        SteelGrade = RndString(6),
                        PlateManufacturer = plateManufacturers[rnd.Next(plateManufacturers.Length - 1)],
                        IsActive = true
                    }
                    );
                firstSetupRepo.HeatRepo.Save(heats[i]);
            }

            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region PurchaseOrder
            List<PurchaseOrder> orders = new List<PurchaseOrder>
            {
                new PurchaseOrder {Number = RndString(5),Date = DateTime.Now.AddMonths(-rnd.Next(10)),IsActive=true},
                new PurchaseOrder {Number = RndString(5),Date = DateTime.Now.AddMonths(-rnd.Next(10)),IsActive=true},
                new PurchaseOrder {Number = RndString(5),Date = DateTime.Now.AddMonths(-rnd.Next(10)),IsActive=true},
                new PurchaseOrder {Number = RndString(5),Date = DateTime.Now.AddMonths(-rnd.Next(10)),IsActive=true},
                new PurchaseOrder {Number = RndString(5),Date = DateTime.Now.AddMonths(-rnd.Next(10)),IsActive=true}
            };
            orders.ForEach(s => firstSetupRepo.PurchaseRepo.Save(s));
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region MillPipe
            List<Pipe> pipes = new List<Pipe>();
            for(int i = 0; i < PIPECOUNT; i++)
            {
                var plate = new Plate
                    {
                        Number = RndString(8),
                        Thickness = rnd.Next(2000),
                        Heat = heats[rnd.Next(heats.Count - 1)],
                        IsActive = true
                    };
                firstSetupRepo.PlateRepo.Save(plate);

                var pipe = new Pipe
                {
                    Number = RndString(8),
                    Plate = plate,
                    Mill = viewModel.MillName,
                    Diameter = types[0].Diameter,
                    WallThickness = types[0].Thickness,
                    Type = types[rnd.Next(1)],
                    PurchaseOrder = orders[orders.Count - 1],
                    Project = viewModel.Project,
                    Status = PipeMillStatus.Produced,
                    ProductionDate = DateTime.Now.AddDays(-rnd.Next(20)),
                    ToExport = true,
                    IsActive = true
                };
                pipe.RecalculateWeight();

                var results = new List<PipeTestResult>();
                foreach(var item in tests.Where(x => x.pipeType == pipe.Type))
                {
                    var testResult = new PipeTestResult
                    {
                        Operation = item,
                        Pipe = pipe,
                        Status = PipeTestResultStatus.Scheduled
                    };
                    results.Add(testResult);
                    firstSetupRepo.PipeTestResultRepo.Save(testResult);
                }
                pipe.PipeTestResult = results;
                pipes.Add(pipe);
                if(pipes.Count % 4 == 0)
                {
                    foreach(var item in pipe.PipeTestResult)
                    {
                        item.Status = PipeTestResultStatus.Passed;
                    }
                    pipe.Status = PipeMillStatus.Stocked;
                    pipe.ConstructionStatus = PartConstructionStatus.Pending;
                    pipe.IsAvailableToJoint = true;
                }


                firstSetupRepo.PipeRepo.Save(pipe);
            };
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region Inspector
            List<Inspector> inspectors = new List<Inspector>();
            for(int i = 0; i < INSPECTORCOUNT; i++)
            {
                var insp = new Inspector
                    {
                        Grade = rnd.Next(6),
                        Name = new PersonName
                        {
                            FirstName = RndName(fNames),
                            LastName = RndName(lNames),
                            MiddleName = RndName(mNames),
                        },
                        IsActive = true
                    };
                insp.Certificates = CreateInspectorCertificates(insp, inspetorCertTypes);
                inspectors.Add(insp);
                firstSetupRepo.InspectorRepo.Save(insp);
            }
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region Welder
            List<Welder> welders = new List<Welder>();

            for(int i = 0; i < WELDERCOUNT; i++)
            {
                var welder = new Welder
                    {
                        Grade = rnd.Next(6),
                        Name = new PersonName
                        {
                            FirstName = RndName(fNames),
                            LastName = RndName(lNames),
                            MiddleName = RndName(mNames),
                        },
                        Stamp = RndString(12),
                        Certificate = new Certificate
                        {
                            Number = RndString(14),
                            ExpirationDate = DateTime.Now.AddDays(rnd.Next(60)),
                            IsActive = true
                        },
                        IsActive = true
                    };
                welders.Add(welder);
                firstSetupRepo.WelderRepo.Save(welder);
            }
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region ComponentType
            ComponentType[] componentTypes = 
            {
                new ComponentType{Name = "Заглушка",ConnectorsCount = 1, IsActive = true},
                new ComponentType{Name = "Переходник",ConnectorsCount = 2, IsActive = true},
                new ComponentType{Name = "Т - Соединение",ConnectorsCount = 3, IsActive = true},
                new ComponentType{Name = "Тройник",ConnectorsCount = 3, IsActive = true}
            };
            foreach(var item in componentTypes)
            {
                firstSetupRepo.ComponentTypeRepo.Save(item);
            }
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region Component
            List<Domain.Entity.Construction.Component> components = new List<Domain.Entity.Construction.Component>();

            foreach(var type in componentTypes)
            {
                for(int i = 0; i < COMPONENTCOUNT; i++)
                {
                    var component = CreateComponent(type);
                    firstSetupRepo.ComponentRepo.Save(component);
                    components.Add(component);
                }
            }

            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region Release
            List<ReleaseNote> releases = new List<ReleaseNote>();
            for(int i = 0; i < RELEASECOUNT; i++)
            {
                ReleaseNote release = new ReleaseNote
                {
                    Number = RndString(10),
                    Shipped = false,
                    Date = DateTime.Now.AddDays(-rnd.Next(10)),
                    IsActive = true
                };
                release.Railcars = CreateRailcars(rnd.Next(2, 5));
                firstSetupRepo.ReleaseRepo.Save(release);
            }
            #endregion
            firstSetupRepo.Commit();

            return false;
        }

        private IList<Domain.Entity.Mill.Railcar> CreateRailcars(int num)
        {
            List<Domain.Entity.Mill.Railcar> cars = new List<Domain.Entity.Mill.Railcar>();
            for(int i = 0; i < num; i++)
            {
                var car = new Domain.Entity.Mill.Railcar
                {
                    Number = RndString(10),
                    Certificate = RndString(8),
                    Destination = "Destination " + i,
                    IsActive = true
                };
                firstSetupRepo.RailRepo.Save(car);
                cars.Add(car);
            }
            return cars;
        }

        private Domain.Entity.Construction.Component CreateComponent(ComponentType componentType)
        {
            var component = new Domain.Entity.Construction.Component
            {
                ConstructionStatus = PartConstructionStatus.Pending,
                InspectionStatus = PartInspectionStatus.Pending,
                Certificate = RndString(12),
                Length = rnd.Next(1000),
                Number = RndString(14),
                Type = componentType,
                IsAvailableToJoint = true,
                ToExport = true,
                IsActive = true
            };
            for(int j = 0; j < componentType.ConnectorsCount; j++)
            {
                var con = new Connector
                {
                    Component = component,
                    Diameter = rnd.Next(1217, 1221),
                    WallThickness = rnd.Next(40, 50),
                    IsActive = true
                };
                component.Connectors.Add(con);
            }
            return component;
        }

        private IList<InspectorCertificate> CreateInspectorCertificates(Inspector insp, List<InspectorCertificateType> types)
        {
            List<InspectorCertificate> certs = new List<InspectorCertificate>();
            foreach(var item in types)
            {
                var iCert = new InspectorCertificate
                {
                    Inspector = insp,
                    Certificate = new Certificate { Number = RndString(6), ExpirationDate = DateTime.Now.AddDays(rnd.Next(60)) },
                    Type = item
                };
                certs.Add(iCert);
            }
            return certs;

        }

        private string RndString(int size)
        {
            string result = String.Empty;
            if(size < 32)
            {
                result = Guid.NewGuid().ToString("N").Substring(0, size).ToUpper();
            }
            else
            {
                var ex = new ArgumentException("Out of range");
                log.Error(ex.Message);
                throw ex;
            }
            return result;
        }

        private string[] fNames = { "Иван", "Сергей", "Николай", "Петр", "Савелий", "Исаак", "Фрол" };
        private string[] lNames = { "Иванов", "Самойлов", "Снигирев", "Голубев", "Татарский", "Колинич", "Леонов" };
        private string[] mNames = { "Петрович", "Николаевич", "Сергеевич", "Анатольевич", "Владимирович", "Георгиевич", "Павлович" };


        //random names
        public string RndName(string[] arr)
        {
            return arr[rnd.Next(arr.Length - 1)];
        }

        #region IDisposable Members

        public void Dispose()
        {
            firstSetupRepo.Dispose();
        }

        #endregion
    }
}

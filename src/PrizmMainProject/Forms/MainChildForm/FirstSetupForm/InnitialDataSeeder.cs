using Prizm.Domain.Entity;
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
        IFirstSetupRepo firstSetupRepo;

        public InnitialDataSeeder()
        {
            this.firstSetupRepo = new FirstSetupRepo();
        }

        private Random rnd = new Random();

        public bool SeedOptional(FirstSetupViewModel vm)
        {
            // first of all
            firstSetupRepo.BeginTransaction();

            #region SeamTypes
            SeamType[] seamTypes = 
            {
                new SeamType{Name = "Бесшовный", IsActive = true},
                new SeamType{Name = "Прямой", IsActive = true},
                new SeamType{Name = "Спиралевидный", IsActive = true},
            };
            foreach(var item in seamTypes)
            {
                firstSetupRepo.SeemTypeRepo.Save(item);
            }
            firstSetupRepo.Commit();
            
            #endregion
            firstSetupRepo.BeginTransaction();
            #region PipeMillSyzeType
            PipeMillSizeType[] types = 
            {
                new PipeMillSizeType
                {
                    Type = "1500 X 100500 X 50 - бесшовный",
                    IsActive = true,
                    Length = 9090,
                    Diameter = 1212,
                    Thickness = 12,
                    SeamType = seamTypes[0]
                }
            };
            Array.ForEach(types, s => firstSetupRepo.SizeTypeRepo.Save(s));
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region PipeTestCategory
            Category[] categories = {
                #region creating pipe test category
		        new Category { Name = "Категория - 1", Fixed = false, Type = FixedCategory.Undef, IsActive = true},
                new Category { Name = "Категория - 2", Fixed = false, Type = FixedCategory.Undef, IsActive = true},
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
            PipeTest[] tests = 
            {
                #region creating pipetests
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
                } 
	#endregion
            };

            foreach(var test in tests)
            {
                firstSetupRepo.TestRepo.Save(test);
            }
            #endregion
            firstSetupRepo.Commit();
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
            for(int i = 0; i < 15; i++)
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
            #region Railcar
            Domain.Entity.Mill.Railcar[] cars = 
            {
                new Domain.Entity.Mill.Railcar
                {
                    Number = RndString(6),
                    Certificate = RndString(8),
                    Destination = "Строительство 1",
                    IsShipped = false,
                    IsActive = true
                },
                new Domain.Entity.Mill.Railcar
                {
                    Number = RndString(6),
                    Certificate = RndString(8),
                    Destination = "Строительство 2",
                    IsShipped = false,
                    IsActive = true
                },
                new Domain.Entity.Mill.Railcar
                {
                    Number = RndString(6),
                    Certificate = RndString(8),
                    Destination = "Строительство 3",
                    IsShipped = false,
                    IsActive = true
                },
            };
            Array.ForEach(cars, s => firstSetupRepo.RailRepo.Save(s));
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region MillPipe
            List<Pipe> pipes = new List<Pipe>();
            for(int i = 0; i < 150; i++)
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
                    Mill = vm.MillName,
                    Diameter = types[0].Diameter,
                    WallThickness = types[0].Thickness,
                    Type = types[0],
                    PurchaseOrder = orders[orders.Count - 1],
                    Project = vm.Project,
                    Status = PipeMillStatus.Produced,
                    ProductionDate = DateTime.Now.AddDays(-rnd.Next(20)),
                    ToExport = true,
                    IsActive = true
                };
                pipe.RecalculateWeight();

                var results = new List<PipeTestResult>();
                foreach(var item in tests)
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
                firstSetupRepo.PipeRepo.Save(pipe);
            };
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region InspectorCertificateTypes
            List<InspectorCertificateType> inspetorCertTypes = new List<InspectorCertificateType>
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
            #region Inspector
            List<Inspector> inspectors = new List<Inspector>();
            for(int i = 0; i < 20; i++)
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
                insp.Certificates = CreateInspectorCertificates(insp,inspetorCertTypes);
                inspectors.Add(insp);
                firstSetupRepo.InspectorRepo.Save(insp);
            }
            #endregion
            firstSetupRepo.Commit();
            firstSetupRepo.BeginTransaction();
            #region JointOperation

            #endregion
            firstSetupRepo.Commit();


            return false;
        }

        private IList<InspectorCertificate> CreateInspectorCertificates(Inspector insp, List<InspectorCertificateType >types)
        {
            List<InspectorCertificate> certs = new List<InspectorCertificate>();
            foreach(var item in types)
            {
                var iCert = new InspectorCertificate
                {
                    Inspector = insp,
                    Certificate = new Certificate {Number = RndString(6),ExpirationDate = DateTime.Now.AddDays(rnd.Next(60))},
                    Type = item
                };
                certs.Add(iCert);
            }
            return certs;
            
        }

        public bool SeedRequired(FirstSetupViewModel vm)
        {
            return false;
        }

        private string RndString(int size)
        {
            string result = String.Empty;
            if(size < 32)
            {
                result = Guid.NewGuid().ToString("N").Substring(0, size);
            }
            else
            {
                throw new ArgumentException("Out of range");
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

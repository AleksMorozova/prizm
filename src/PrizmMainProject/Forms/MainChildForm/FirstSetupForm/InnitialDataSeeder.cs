using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public class InnitialDataSeeder
    {
        IFirstSetupRepo firstSetupRepo;

        public InnitialDataSeeder()
        {
            this.firstSetupRepo = new FirstSetupRepo();
        }

        public bool SeedOptional()
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
            Array.ForEach(seamTypes, s => firstSetupRepo.SeemTypeRepo.Save(s));

            #endregion

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
                },
            };
            Array.ForEach(types, s => firstSetupRepo.SizeTypeRepo.Save(s));
            #endregion

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
                    Category = categories[0],
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
                    Category = categories[0],
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
                    Category = categories[0],
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
                    Category = categories[1],
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
                    Category = categories[0],
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
                    Category = categories[0],
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

            //after All
            firstSetupRepo.Commit();
            return false;
        }

        public bool SeedRequired()
        {
            return false;
        }
    }
}

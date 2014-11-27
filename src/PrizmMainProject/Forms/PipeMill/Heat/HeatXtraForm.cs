using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ninject;
using Ninject.Parameters;
using PrizmMain.Forms.MainChildForm;
using System.Linq;
using System.Collections.Generic;
using Domain.Entity.Mill;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public partial class HeatXtraForm : ChildForm
    {

        private HeatViewModel viewModel;

        public HeatXtraForm() : this("")
        {

        }

        public HeatXtraForm(string heatNumber)
        {
            InitializeComponent();
            viewModel = (HeatViewModel)Program.Kernel.Get<HeatViewModel>(new ConstructorArgument("heatNumber", heatNumber));
            Dummy();
        }

        private void HeatXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {

            //bindingSource.DataSource = viewModel;
            //number.Properties.DataSource = viewModel.AllHeats;
            //number.DataBindings.Add("EditValue", bindingSource, "Heat");
            //steelGrade.DataBindings.Add("EditValue", bindingSource, "Steel");

        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
        }

        private void HeatXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }

        private void number_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (viewModel.AllHeats.Where(x => x.Number.Equals(number.Text)) != null)
            //{
            //    viewModel.GetHeatByNumber(number.Text);
            //}
            //else
            //{
            //    viewModel.NewHeat(number.Text);
            //}
        }

        private void number_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
                //viewModel.NewHeat(number.Text);
        }


        #region DummyData

        private void Dummy() 
        {
            List<Domain.Entity.Mill.Heat> heats = new List<Domain.Entity.Mill.Heat>()
        {
            new Domain.Entity.Mill.Heat(){Number = "1256985"},
            new Domain.Entity.Mill.Heat(){Number = "2456867"},
            new Domain.Entity.Mill.Heat(){Number = "7435611"},
            new Domain.Entity.Mill.Heat(){Number = "1451363"},
            new Domain.Entity.Mill.Heat(){Number = "6451238"},
            new Domain.Entity.Mill.Heat(){Number = "7652359"},
            new Domain.Entity.Mill.Heat(){Number = "125855"}
        };
            number.Properties.DataSource = heats;
            number.EditValue = number.Properties.GetKeyValue(0);

            List<PlateManufacturer> manufacturers = new List<PlateManufacturer>()
            {
                new PlateManufacturer(){Name = "Криворожский металургический комбинат"},
                new PlateManufacturer(){Name = "Нижнеднепровский трубопрокатный завод"},
                new PlateManufacturer(){Name = "Армавирский завод промышленного оборудования"},
                new PlateManufacturer(){Name = "Новгородский металургический завод"},
                new PlateManufacturer(){Name = "Гурьевский металургический завод"},
                new PlateManufacturer(){Name = "Ижевский металургический завод"},
                new PlateManufacturer(){Name = "Щелковский металургический завод"}
            };
            plateManufacturer.Properties.DataSource = manufacturers;
            plateManufacturer.EditValue = plateManufacturer.Properties.GetKeyValue(0);

            List<ChemicalComposition> chem = new List<ChemicalComposition>()
        {
            new ChemicalComposition(){Parameter = "C",HeatValue = 0.06f, PlateValue = 0.06f,PipeValue = 0.06f},
            new ChemicalComposition(){Parameter = "Mn",HeatValue = 1.64f, PlateValue = 1.64f},
            new ChemicalComposition(){Parameter = "Si",HeatValue = 0.29f ,PlateValue = 0.29f,PipeValue = 0.29f},
            new ChemicalComposition(){Parameter = "P",HeatValue = 0.007f, PlateValue = 0.006f,PipeValue = 0.006f},
            new ChemicalComposition(){Parameter = "S",HeatValue = 0.001f, PlateValue = 0,},
            new ChemicalComposition(){Parameter = "Mo",HeatValue = 0.175f, PlateValue = 0.175f}
        };
            chemicalGrid.DataSource = chem;
            steelGrade.Text = "H18N9T";

            List<TensileTest> tests = new List<TensileTest>()
            {
                new TensileTest()
                {
                    Parameter = "Предел текучести, Rt0.5,",
                    BaseValue = 645f,
                },
                new TensileTest()
                {
                    Parameter = "Временное сопротивление, Rm,МПа",
                    BaseValue = 700f,
                },
                new TensileTest()
                {
                    Parameter = "Удлиннение на 2 дюймах (50,8мм)",
                    BaseValue = 32f,
                },
                new TensileTest()
                {
                    Parameter = "ИПГ при t=0С,ср.,%",
                    BaseValue = 100f,
                },
                new TensileTest()
                {
                    Parameter = "Доля вязкой сост. на ударных образцах при t=-10C,ср.,%",
                    BaseValue = 100f,
                },
            };

            phisicalGrid.DataSource = tests;



        }

        

        #endregion
    }
}
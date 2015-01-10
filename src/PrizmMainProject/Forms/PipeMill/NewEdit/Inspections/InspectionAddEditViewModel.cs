using DevExpress.Mvvm;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.NewEdit.Inspections
{
    public class InspectionAddEditViewModel : ViewModelBase, IDisposable
    {
        private IList<PipeTest> tests = new BindingList<PipeTest>();
        private IList<Inspector> inspectors = new BindingList<Inspector>();
        private PipeTest test;

        public InspectionAddEditViewModel(IList<PipeTest> tests, IList<Inspector> inspectors, PipeTest current)
        {
            this.tests = tests;
            this.inspectors = inspectors;
            if(current == null)
            {
                test = new PipeTest() { Category = new Domain.Entity.Mill.Category()};
            }
            else
            {
                test = current;
            }
        }

        public IList<Inspector> Inspectors
        {
            get { return inspectors; }
            set
            {
                if(value != inspectors)
                {
                    inspectors = value;
                    RaisePropertyChanged("Inspectors");
                }
            }
        }

        public IList<PipeTest> Tests
        {
            get { return tests; }
            set
            {
                if(value != tests)
                {
                    tests = value;
                    RaisePropertyChanged("Tests");
                }
            }
        }

        public PipeTest Test
        { 
            get { return test; }
            set
            {
                if(value != test)
                {
                    test = value;
                    RaisePropertyChanged("Test");
                }
            }
        }

        public string Category
        {
            get { return test.Category.Name; }
            set
            {
                if(value != test.Category.Name)
                {
                    test.Category.Name = value;
                    RaisePropertyChanged("Category");
                }
            }
        }

        public string Name
        {
            get { return test.Name; }
            set
            {
                if(value != test.Name)
                {
                    test.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }



        #region IDisposable Members

        public void Dispose()
        {
            
        }

        #endregion
    }
}

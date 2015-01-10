using DevExpress.Mvvm;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
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
        private PipeTest test = new PipeTest() { Category = new Domain.Entity.Mill.Category()};
        private PipeTestResult result;
        public IList<Main.Common.EnumWrapper<PipeTestResultStatus>> statuses;


        public InspectionAddEditViewModel(IList<PipeTest> tests, IList<Inspector> inspectors, 
            PipeTestResult current, IList<Main.Common.EnumWrapper<PipeTestResultStatus>> statuses)
        {
            this.tests = tests;
            this.inspectors = inspectors;
            this.statuses = statuses;
            if(current == null)
            {
                this.result = new PipeTestResult() { Status = PipeTestResultStatus.Scheduled };
            }
            else
            {
                this.result = current;
            }
        }

   #region Test
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

        public string Expected
        {
            get 
            {
                string result = string.Empty;
                switch(test.ResultType)
                {
                    case PipeTestResultType.Boolean:
                        result = test.BoolExpected.ToString();
                        break;
                    case PipeTestResultType.String:
                        result = test.StringExpected;
                        break;
                    case PipeTestResultType.Diapason:
                        result = test.MinExpected + " - " + test.MaxExpected;
                        break;
                    case PipeTestResultType.Undef:
                        break;
                    default:
                        break;
                }
                return result;
            }
            set { }
        } 
	#endregion

        #region Result

        //TODO: wrapper for translit
        public PipeTestResultStatus Status
        {
            get { return result.Status; }
            set
            {
                if(value != result.Status)
                {
                    result.Status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }
	#endregion





        #region IDisposable Members

        public void Dispose()
        {
            
        }

        #endregion
    }
}

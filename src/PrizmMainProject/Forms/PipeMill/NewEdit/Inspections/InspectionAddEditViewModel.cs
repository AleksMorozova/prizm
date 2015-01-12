using DevExpress.Mvvm;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
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
        private IList<PipeTest> availableTests = new BindingList<PipeTest>();
        private IList<Inspector> inspectors = new BindingList<Inspector>();
        private PipeTestResult testResult;
        public IList<EnumWrapper<PipeTestResultStatus>> statuses;


        public InspectionAddEditViewModel(IList<PipeTest> tests, IList<Inspector> inspectors,
            PipeTestResult current, IList<Main.Common.EnumWrapper<PipeTestResultStatus>> statuses)
        {
            this.availableTests = tests;
            this.inspectors = inspectors;
            this.statuses = statuses;
            if(current == null)
            {
                TestResult = new PipeTestResult() { Status = PipeTestResultStatus.Scheduled };
                TestResult.Operation = new PipeTest();
                //TODO: Check availableTests is null
                TestResult.Operation = this.availableTests[0];
            }
            else
            {
                TestResult = current;
            }
            if(testResult.Value == null)
            {
                testResult.Value = string.Empty;
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
            get { return availableTests; }
            set
            {
                if(value != availableTests)
                {
                    availableTests = value;
                    RaisePropertyChanged("Tests");
                }
            }
        }

        public PipeTest Test
        {
            get { return testResult.Operation; }
            set
            {
                if(value != testResult.Operation)
                {
                    testResult.Operation = value;
                    RaisePropertyChanged("Test");
                }
            }
        }

        public string Code
        {
            get { return testResult.Operation.Code; }
            set
            {
                if(value != testResult.Operation.Code)
                {
                    testResult.Operation.Code = value;
                    RaisePropertyChanged("Code");
                }
            }
        }

        public string Category
        {
            get { return testResult.Operation.Category.Name; }
            set
            {
                if(value != testResult.Operation.Category.Name)
                {
                    testResult.Operation.Category.Name = value;
                    RaisePropertyChanged("Category");
                }
            }
        }

        public string Name
        {
            get { return testResult.Operation.Name; }
            set
            {
                if(value != testResult.Operation.Name)
                {
                    testResult.Operation.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string Expected
        {
            get
            {
                string expStr = string.Empty;
                switch(testResult.Operation.ResultType)
                {
                    case PipeTestResultType.Boolean:
                        expStr = testResult.Operation.BoolExpected.ToString();
                        break;
                    case PipeTestResultType.String:
                        expStr = testResult.Operation.StringExpected;
                        break;
                    case PipeTestResultType.Diapason:
                        expStr = testResult.Operation.MinExpected + " - " + testResult.Operation.MaxExpected;
                        break;
                    case PipeTestResultType.Undef:
                        break;
                    default:
                        break;
                }
                return expStr;
            }
            set { }
        }

        private string GetResult()
        {
            string expStr = string.Empty;
            switch(testResult.Operation.ResultType)
            {
                case PipeTestResultType.Boolean:
                    expStr = testResult.Operation.BoolExpected.ToString();
                    break;
                case PipeTestResultType.String:
                    expStr = testResult.Operation.StringExpected;
                    break;
                case PipeTestResultType.Diapason:
                    expStr = testResult.Operation.MinExpected + " - " + testResult.Operation.MaxExpected;
                    break;
                case PipeTestResultType.Undef:
                    break;
                default:
                    break;
            }
            return expStr;

        }
        #endregion

        #region Result
        public PipeTestResult TestResult
        {
            get { return testResult; }
            set
            {
                if(value != testResult)
                {
                    testResult = value;
                    RaisePropertyChanged("TestResult");
                }
            }
        }

        //TODO: wrapper for translit
        public PipeTestResultStatus Status
        {
            get { return testResult.Status; }
            set
            {
                if(value != testResult.Status)
                {
                    testResult.Status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }

        public DateTime Date
        {
            get 
            {
                if(testResult.Date.HasValue)
                {
                    return testResult.Date.Value;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                if(value != testResult.Date)
                {
                    testResult.Date = value;
                    RaisePropertyChanged("Date");
                }
            }
        }

        public PipeTest Operation
        {
            get { return testResult.Operation; }
            set
            {
                if(value != testResult.Operation)
                {
                    testResult.Operation = value;
                    RaisePropertyChanged("Operation");
                }
            }
        }

        public bool FactBool
        {
            get 
            {
                return (testResult.Value.Equals("True")) ? true : false; 
            }
            set
            {
                string input = value.ToString();
                if(!testResult.Value.Equals(input))
                {
                    testResult.Value = input;
                    RaisePropertyChanged("FactBool");
                }
            }
        }

        public string FactString
        {
            get { return testResult.Value; }
            set
            {
                if(value != testResult.Value)
                {
                    testResult.Value = value;
                    RaisePropertiesChanged("FactString");
                }
            }
        }

        public string FactLimit
        {
            get { return testResult.Value; }
            set
            {
                if(value != testResult.Value)
                {
                    testResult.Value = value;
                    RaisePropertiesChanged("FactLimit");
                }
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {

        }

        #endregion

        internal void ChangeTest(string code)
        {
            var test = availableTests.FirstOrDefault(x => x.Code == code);
            Operation = test;
        }

        internal IList<Inspector> SelectInspectors()
        {
            return testResult.Inspectors;
        }
    }
}

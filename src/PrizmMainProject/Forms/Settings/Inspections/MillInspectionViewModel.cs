using DevExpress.Mvvm;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Settings.Inspections
{
    public class MillInspectionViewModel : ViewModelBase
    {
        private PipeTest pipeTest;
        public BindingList<PipeTest> RepeatTestCandidates{get;set;}
        public BindingList<Category> CategoryTypes;

        public MillInspectionViewModel(PipeTest current, BindingList<Category> CategoryTypes, IReadOnlyList<PipeTest> pipeTests)
        {
            SetupViewModel(current, CategoryTypes, pipeTests);
        }

        public void SetupViewModel(PipeTest current, BindingList<Category> CategoryTypes, IReadOnlyList<PipeTest> pipeTests) 
        {
            this.CategoryTypes = CategoryTypes;
            IList<PipeTest> list = pipeTests.Where(_ => _.IsActive && !String.IsNullOrEmpty( _.Code)).OrderBy(x => x.Code).ToList<PipeTest>();
            RepeatTestCandidates = new BindingList<Domain.Entity.Setup.PipeTest>(list);
            pipeTest = new PipeTest();

            if (current != null)
            {
                pipeTest.CustomShallowCopy(current);
                if (current.Id != Guid.Empty)
                {
                    PipeTest curr = RepeatTestCandidates.Where(s => s.Id == pipeTest.Id).SingleOrDefault();
                    RepeatTestCandidates.Remove(curr);
                }
            }
        }

        #region PipeTest
        public PipeTest PipeTest
        {
            get { return pipeTest; }
            set
            {
                if (value != pipeTest)
                {
                    pipeTest = value;
                    RaisePropertyChanged("PipeTest");
                }
            }
        }

        public string Code
        {
            get { return pipeTest.Code; }
            set
            {
                if (value != pipeTest.Code)
                {
                    pipeTest.Code = value;
                    RaisePropertyChanged("Code");
                }
            }
        }

        public string Name
        {
            get { return pipeTest.Name; }
            set
            {
                if (value != pipeTest.Name)
                {
                    pipeTest.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public bool IsRequired
        {
            get { return pipeTest.IsRequired; }
            set
            {
                if (value != pipeTest.IsRequired)
                {
                    pipeTest.IsRequired = value;
                    RaisePropertyChanged("IsRequired");
                }
            }
        }

        public bool IsActive
        {
            get { return pipeTest.IsActive; }
            set
            {
                if (value != pipeTest.IsActive)
                {
                    pipeTest.IsActive = value;
                    RaisePropertyChanged("IsActive");
                }
            }
        }

        public PipeTestResultType ResultType
        {
            get { return pipeTest.ResultType; }
            set
            {
                if (value != pipeTest.ResultType)
                {
                    pipeTest.ResultType = value;
                    RaisePropertyChanged("ResultType");
                }
            }
        }

        public PipeTestControlType PipeTestControlType
        {
            get { return pipeTest.ControlType; }
            set
            {
                if (value != pipeTest.ControlType)
                {
                    pipeTest.ControlType = value;
                    RaisePropertyChanged("PipeTestControlType");
                }
            }
        }

        public Category Category
        {
            get { return pipeTest.Category; }
            set
            {
                if (value != pipeTest.Category)
                {
                    pipeTest.Category = value;
                    RaisePropertyChanged("Category");
                }
            }
        }

        public bool BoolExpected
        {
            get { return pipeTest.BoolExpected; }
            set 
            {
                if (value != pipeTest.BoolExpected)
                {
                    pipeTest.BoolExpected = value;
                    RaisePropertyChanged("BoolExpected");
                }
            }
        }

        public int MinExpected
        {
            get { return pipeTest.MinExpected; }
            set
            {
                if (value != pipeTest.MinExpected)
                {
                    pipeTest.MinExpected = value;
                    RaisePropertyChanged("MinExpected");
                }
            }
        }

        public int MaxExpected
        {
            get { return pipeTest.MaxExpected; }
            set
            {
                if (value != pipeTest.MaxExpected)
                {
                    pipeTest.MaxExpected= value;
                    RaisePropertyChanged("MaxExpected");
                }
            }
        }

        public int FrequencyQuantaty
        {
            get { return (pipeTest.Frequency == null)? 0 : pipeTest.Frequency.Quantaty; }
            set
            {
                if (value != pipeTest.Frequency.Quantaty)
                {
                    pipeTest.Frequency.Quantaty = value;
                    RaisePropertyChanged("FrequencyQuantaty");
                }
            }
        }

        public FrequencyMeasure FrequencyMeasure
        {
            get { return (pipeTest.Frequency == null) ? FrequencyMeasure.Undefined : pipeTest.Frequency.Measure; }
            set
            {
                if (value != pipeTest.Frequency.Measure)
                {
                    pipeTest.Frequency.Measure= value;
                    RaisePropertyChanged("FrequencyMeasure");
                }
            }
        }

        public int ResultTypeIndex
        {
            get { return (int)ResultType - 1; }
            set
            {
                if (value != (int)ResultType - 1)
                {
                    ResultType = (PipeTestResultType)value + 1;
                    RaisePropertyChanged("ResultTypeIndex");
                }
            }
        }

        public int ControlTypeIndex
        {
            get { return (int)PipeTestControlType - 1; }
            set
            {
                if (value != (int)PipeTestControlType - 1)
                {
                    PipeTestControlType = (PipeTestControlType)value + 1;
                    RaisePropertyChanged("ControlTypeIndex");
                }
            }
        }

        public int FrequencyMeasureIndex
        {
            get { return (int)FrequencyMeasure - 1; }
            set 
            {
                if (value != (int)FrequencyMeasure - 1)
                {
                    FrequencyMeasure = (FrequencyMeasure)value + 1;
                    RaisePropertyChanged("FrequencyMeasureIndex");
                }
            }
        }
        #endregion
    }
}

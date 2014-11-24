using Domain.Entity.Mill;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill
{
    public class PipeMillStatusWrapper
    {
        public PipeMillStatus Value { get; set; }

        public string Name
        {
            get
            {
                return Enum.GetName(typeof(PipeMillStatus), Value);
            }
            set
            {
                if (value != Name)
                {
                    Value = (PipeMillStatus)Enum.Parse(typeof(PipeMillStatus), value);
                }
            }
        }

        public string Text
        {
            get
            {
                return Resources.ResourceManager.GetString(Name);
            }
            set { }
        }


        public override string ToString()
        {
            return Text;
        }
    }
}

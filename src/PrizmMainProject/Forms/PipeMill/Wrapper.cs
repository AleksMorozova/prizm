using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill
{
    public class Wrapper<TEnum>
    {

        public TEnum Value { get; set; }

        public string Name
        {
            get
            {
                if (Value == null)
                {
                    return string.Empty;
                }
                return Enum.GetName(typeof(TEnum), Value);
            }
            set
            {
                if (value != Name)
                {
                    Value = (TEnum)Enum.Parse(typeof(TEnum), value);
                }
            }
        }

        public string Text
        {
            get
            {
                return Resources.ResourceManager.GetString(Name);
            }
        }


        public override string ToString()
        {
            return Text;
        }
    }
}

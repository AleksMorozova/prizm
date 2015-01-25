using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    /// <summary>
    /// Generic wrapper for Enum type which use embedded resources 
    /// </summary>
    /// <typeparam name="TEnum">Enum type</typeparam>
    public class EnumWrapper<TEnum> where TEnum : struct, IConvertible
    {
        private class PrivateEnumerator : IEnumerable<Tuple<int, string>>
        {
            private bool skip0;
            public PrivateEnumerator(bool skip0 = false)
            {
                this.skip0 = skip0;
            }

            public IEnumerator<Tuple<int, string>> GetEnumerator()
            {
                var type = typeof(TEnum);
                if (!type.IsEnum)
                {
                    throw new ArgumentException(string.Format("{0} must be an enumerated type", type));
                }
                int index = this.skip0 ? 1 : 0;
                while (Enum.IsDefined(type, index))
                {
                    yield return new Tuple<int, string>(index, Enum.GetName(type, index));
                    index++;
                }
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }

        public static IEnumerable<Tuple<int, string>> EnumerateItems(bool skip0 = false)
        {
            return new PrivateEnumerator(skip0);
        }

        /// <summary>
        /// The Enum value, which will be wrapped
        /// </summary>
        public TEnum Value { get; set; }
        /// <summary>
        /// The nativ name of Enum value
        /// </summary>
        public string Name
        {
            get
            {
                return "";
            }
            set
            {
                
            }
        }

        /// <summary>
        /// the translated value  of Enum, which is displayed in the control
        /// </summary>
        public string Text
        {
            get
            {/*
                string result = Resources.ResourceManager.GetString(typeof(TEnum).Name + "_" + Name);
                result = String.IsNullOrEmpty(result) ? Resources.ResourceManager.GetString(Name) : result;
                return result;*/
                return "";
            }
        }

        /// <summary>
        /// overridden for comboBox displaying
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Text;
        }
    }
}

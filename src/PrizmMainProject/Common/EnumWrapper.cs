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
        #region --- Enumerator ---

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

        #endregion // --- Enumerator ---

        #region --- Conversion --- 

        private System.Type type;

        public EnumWrapper()
            : this(default(TEnum))
        {
        }

        public EnumWrapper(TEnum value)
        {
            this.type = typeof(TEnum);
            Value = value;
        }

        /// <summary>
        /// Use with caution: name should strictly correspond to one of enum items
        /// </summary>
        /// <param name="name"></param>
        public EnumWrapper(string name)
        {
            this.type = typeof(TEnum);
            Name = name;
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
                return Enum.GetName(type, Value);
            }
            set
            {
                Value = (TEnum)Enum.Parse(this.type, value);
            }
        }

        // TODO: care about data binding by Text (grids)
        public string Text
        {
            get
            {
                return Name;
            }
        }

        public override string ToString()
        {
            return Name;
        }
        #endregion // --- Conversion --- 
    }
}

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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(EnumWrapper<TEnum>));
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
                    var e = new ArgumentException(string.Format("{0} must be an enumerated type", type));
                    log.Error(e.Message);
                    throw e;
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

        #region --- Loading items ---
        public static void LoadItems(List<string> list, bool skip0 = false)
        {
            if (list != null)
            {
                if (list.Count == 0)
                {
                    foreach (var item in EnumWrapper<TEnum>.EnumerateItems(skip0))
                    {
                        list.Add(item.Item2);
                    }
                }
            }
        }

        public static void LoadItems(DevExpress.XtraEditors.Controls.RadioGroupItemCollection radioCollection, bool skip0 = false)
        {
            if (radioCollection != null)
            {
                if (radioCollection.Count == 0)
                {
                    foreach (var item in EnumWrapper<TEnum>.EnumerateItems(skip0))
                    {
                        radioCollection.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(item.Item1, item.Item2));
                    }
                }
            }
        }

        public static void LoadItems(DevExpress.XtraEditors.Controls.ComboBoxItemCollection comboCollection, bool skip0 = false)
        {
            if (comboCollection != null)
            {
                if (comboCollection.Count == 0)
                {
                    foreach (var item in EnumWrapper<TEnum>.EnumerateItems(skip0))
                    {
                        comboCollection.Add(item.Item2);
                    }
                }
            }
        }

        public static void LoadItems(DevExpress.XtraEditors.Controls.CheckedListBoxItemCollection listCollection, 
            System.Windows.Forms.CheckState? state = null, bool? enabled = null, bool skip0 = false)
        {
            if (listCollection != null)
            {
                if (listCollection.Count == 0)
                {
                    foreach (var item in EnumWrapper<TEnum>.EnumerateItems(skip0))
                    {
                        if (state != null && enabled != null)
                        {
                            listCollection.Add(item.Item1, item.Item2, state.Value, enabled.Value);
                        }
                        else 
                        {
                            listCollection.Add(item.Item1, item.Item2);
                        }
                    }
                }
            }
        }

        #endregion //--- Loading items ---

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

using System.ComponentModel;

namespace Prizm.Main.DummyData
{
    public class DictionaryDummy
    {
        public static BindingList<Dictionary> GetDictionaries()
        {
            return new BindingList<Dictionary>
            {
                new Dictionary {DictionaryName = "Статусы стыка"}
            };
        }

        public static BindingList<Item> GetItems()
        {
            return new BindingList<Item>
            {
                new Item {Name = "Забракован"},
                new Item {Name = "Принят"},
                new Item {Name = "Задержан"}
            };
        }
    }

    public class Dictionary
    {
        public string DictionaryName { get; set; }
    }

    public class Item
    {
        public string Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    public class DictionaryDummy
    {
        public static BindingList<Dictionary> GetDictionaries()
        {
            return  new BindingList<Dictionary>()
            {
                new Dictionary {DictionaryName = "Pipe inspection statuses"} 
            };
        }
        public static BindingList<Item> GetItems()
        {
            return new BindingList<Item>()
            {
                new Item {English = "Rejected", Russian = "Забракован"} ,
                new Item {English = "Accepted", Russian = "Принят"}  ,
                new Item {English = "Hold", Russian = "Задержан"} 
            };
        }
    }
        public class Dictionary
    {
        public string DictionaryName { get; set; }
    }

        public class Item
        {
            public string English { get; set; }
            public string Russian { get; set; }
        }
}

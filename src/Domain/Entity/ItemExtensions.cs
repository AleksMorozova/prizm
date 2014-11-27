using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   /// <summary>
   /// Extensions for Item class. Methods cannot be added directly to <see cref="Domain.Entity.Item"/> class
   /// because of Hibernate proxy generation mechanism.
   /// </summary>
   public static class ItemExtensions
   {
      public static bool IsNew(this Item item)
      {
         return item.Id == null || item.Id == Guid.Empty;
      }
   }
}

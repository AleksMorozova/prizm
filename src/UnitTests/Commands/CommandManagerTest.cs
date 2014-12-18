using NUnit.Framework;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Commands
{
   [TestFixture]
   public class CommandManagerTest
   {
      [Test]
      public void TestCommandManagerReturnsTheSameInstanceBySameKey()
      {
         const string COMMAND_NAME = "MyCommand";
         CommandManager cm = new CommandManager();
         var reference1 = cm[COMMAND_NAME];
         var reference2 = cm[COMMAND_NAME];

         Assert.AreSame(reference1, reference2);
      }
   }
}

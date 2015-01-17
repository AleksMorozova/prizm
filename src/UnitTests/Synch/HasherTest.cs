using NUnit.Framework;
using Prizm.Main.Synch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Synch
{
   [TestFixture]
   public class HasherTest
   {
      [Test]
      public void TestComputeSHA1Hash()
      {
         const string TEXT_TO_HASH = "TEXT_TO_HASH";
         const string EXPECTED_HASH = "8be3af11685a01d2f96b48640fcff18ff4db9366";
         
         Hasher hasher = new Hasher();
         string hash = hasher.GetHash(Encoding.UTF8.GetBytes(TEXT_TO_HASH));

         Assert.AreEqual(EXPECTED_HASH, hash);
      }
   }
}

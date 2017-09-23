using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeyorTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {
            int a = 1;

            Assert.That(a, Is.EqualTo(1));
        }
    }
}

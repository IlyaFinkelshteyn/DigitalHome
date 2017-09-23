using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void test()
        {
            int a = 2;

            Assert.That(a, Is.EqualTo(1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestPracticeProject
{
    [TestClass]
    public  class TestWithoutInheritance : ClassGeneric
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Test Method 1 of TestWithInheritance");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Test Method 2 of TestWithInheritance");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("Test Method 3 of TestWithInheritance");
        }
    }
}

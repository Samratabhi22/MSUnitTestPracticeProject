using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestPracticeProject
{
    [TestClass]
    public class TestWithOutInheritance
    {
        [TestMethod]
        public void Method1()
        {
            Console.WriteLine("Method 1 of TestWithOutInheritance");
        }
        [TestMethod]
        public void Method2()
        {
            Console.WriteLine("Method 2 of TestWithOutInheritance");
        }
        [TestMethod]
        public void Method3()
        {
            Console.WriteLine("Method 3 of TestWithOutInheritance");
        }
    }
}

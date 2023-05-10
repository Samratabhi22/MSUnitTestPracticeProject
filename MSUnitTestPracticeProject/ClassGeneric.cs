using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestPracticeProject
{
    [TestClass]
    public class ClassGeneric
    {
        [TestInitialize]
        public void BeforeTestMethod()
        {
            Console.WriteLine("Before Test");
        }
        [TestCleanup]
        public void AfterTestMethod()
        {
            Console.WriteLine("After Test");
        }
    }
}

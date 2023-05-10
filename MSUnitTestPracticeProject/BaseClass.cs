using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestPracticeProject
{
    [TestClass]
    public class BaseClass
    {
        [AssemblyInitialize]
        public static  void BeforeProject(TestContext context)
        {
            Console.WriteLine("Before Project");
        }
        [AssemblyCleanup]
        public static void AfterProject()
        {
            Console.WriteLine("After Project");
        }
    }
}

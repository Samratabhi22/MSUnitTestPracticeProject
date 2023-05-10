using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestPracticeProject
{
    [TestClass]
    public  class TestScriptClass
    {
        [ClassInitialize]
        public static void BeforeClass(TestContext context)
        {
            Console.WriteLine("Before class");
        }
        [ClassCleanup]
        public static void AfterClass()
        {
            Console.WriteLine("After class");
        }
        [TestInitialize]
       public  void BeforeTest() 
        {
            Console.WriteLine("Before Test");
        }
        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("AfterTest");
        }
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("Test 1 method");
        }
        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("Test 2 method");
        }
        [TestMethod]
        public void Test3()
        {
            Console.WriteLine("Test 3 method");
        }
    }
}

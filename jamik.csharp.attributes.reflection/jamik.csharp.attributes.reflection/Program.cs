using System;
using System.Linq;
using System.Reflection;

namespace jamik.csharp.attributes.reflection
{
    public class TestAttribute : Attribute { }
    public class TestMethodAttribute : Attribute
    {
        public TestMethodAttribute()
        {
            Console.WriteLine("Inside TestMethodAttribute constructor!");
        }
    }

    [TestAttribute]
    class MyTestSuite
    {

        public void HelperMethod()
        {
            // That helps our test get their job done...
            Console.WriteLine("This method will never be invoked because it does not have a TestMethodAttribute on it.");
        }

        [TestMethodAttribute]
        public void MyTest1()
        {
            // Doing some testing...
            Console.WriteLine("Doing some testing...");
        }

        [TestMethodAttribute]
        public void MyTestMethod2()
        {
            Console.WriteLine("Other testing...");
        }
    }

    class MeAttribute : Attribute
    {
        public MeAttribute(int age, string name)
        {
            Console.WriteLine("MeAttribute()");
            Console.WriteLine(age);
            Console.WriteLine(name);
        }

        public int SomeIntProperty { get; set; }
        public char SomeCharProperty { get; set; }
    }

    [Me(25, "Jamie King", SomeCharProperty = 'J', SomeIntProperty = 75)]
    [TestMethodAttribute]
    class YourTestSuite { }

    class Program
    {
        static void Main(string[] args)
        {
            // Gets all the types of executing assembly
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                //Console.WriteLine(t.Name);
                foreach (Attribute a in t.GetCustomAttributes())
                {
                    if (a is TestAttribute)
                        Console.WriteLine(t.Name + " is a test suite!");
                }
            }

            // Query syntax for the previous code
            var testSuites =
                from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.GetCustomAttributes().Any(a => a is TestAttribute)
                select t;

            /// Gets all types of executing assenbly and then gets the methods with a specific
            /// attribute and then execute methods
            foreach (Type t in testSuites)
            {
                Console.WriteLine("Running test in suite: " + t.Name);
                var testMethods =
                    from m in t.GetMethods()
                    where m.GetCustomAttributes().Any(a => a is TestMethodAttribute)
                    select m;

                object testSuiteInstance = Activator.CreateInstance(t);
                foreach (MethodInfo mInfo in testMethods)
                {
                    mInfo.Invoke(testSuiteInstance, new object[0]);
                }
            }

            // Example MeAttribute to run Constructor of custon attributes automatically
            typeof(YourTestSuite).GetCustomAttributes();
        }
    }
}

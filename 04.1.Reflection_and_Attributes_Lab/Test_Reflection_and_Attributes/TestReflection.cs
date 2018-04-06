using System;
using Test_Reflection_and_Attributes.Classes;
using Test_Reflection_and_Attributes.Interfaces;

namespace Test_Reflection_and_Attributes
{
    public class TestReflection :  ReflectionBase, IDerivedInterface 
    //, IBaseInterface => or IDerivedInterface inherits IBaseInterface, result is the same.

    {
        private static string privateStaticString;
        public static string publicStaticString;
        private string privateInstance;
        public string publicInstance;
        private string name;

        public TestReflection()
        {
        }

        protected TestReflection(int someNumber)
        {
        }

        private TestReflection(double someDoubleNumber)
        {
        }

        public TestReflection(string someString)
        {
            this.name = someString;
        }

        internal TestReflection(int someNumber, string someString)
        {
        }

        public string Name 
        { 
            get { return this.name; }
            //private set { this.name = value; }
        }
    }
}

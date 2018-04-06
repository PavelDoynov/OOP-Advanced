using System;
using System.Reflection;
using System.Linq;

namespace Test_Reflection_and_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(TestReflection);

            Console.WriteLine(type.FullName); // string fullNameType = typeof(TestReflection).FullName;
            Console.WriteLine(type.Name);  // string nameType = typeof(TestReflection).Name;


            Console.WriteLine();
            Console.WriteLine("Interfaces:");
            Type[] interfaces = type.GetInterfaces();
            interfaces.ToList().ForEach(i => Console.WriteLine(i));


            Console.WriteLine();
            Console.WriteLine("Base Type:");
            Type baseType = type.BaseType;
            Console.WriteLine(baseType);
            Console.WriteLine(type.BaseType.Name); // string baseTypeName = type.BaseType.Name;


            Console.WriteLine();
            Console.WriteLine("Constructors:");  
            //ConstructorInfo[] constructors = type.GetConstructors(); - Only for public constructors
            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | 
                                                                  BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic); 
            constructors.ToList().ForEach(c => Console.WriteLine(c));


            Console.WriteLine();
            Console.WriteLine("Activate / Create instance:");
            // var create = Activator.CreateInstance(typeof(TestReflection)); -  With empty constructor
            // var create = Activator.CreateInstance(typeof(TestReflection), true) - if the ctor is private or protected.
            object create = Activator.CreateInstance(typeof(TestReflection), new object[] {"Pawel"});  // is using ctor with argument string.
            Console.WriteLine("Type name : " + create.GetType().Name);
            PropertyInfo[] prop = create.GetType().GetProperties();
            prop.ToList().ForEach(p => Console.WriteLine("Property name : " + p.Name));
            Console.WriteLine(((TestReflection)create).Name); // We must cast the object, Activator.CreateInstance return a object


            Console.WriteLine();
            Console.WriteLine("Fields:");
            FieldInfo[] fields = type.GetFields
                                     (BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            fields.ToList().ForEach(f => Console.WriteLine(f));


            Console.WriteLine();
            Console.WriteLine("Changing properties without setters or private setters:");
            TestReflection test = (TestReflection)Activator.CreateInstance(typeof(TestReflection), new object[] { "Pawel" });
            Console.WriteLine($"First name : {test.Name}");
            FieldInfo field = type.GetField("name", BindingFlags.Instance | BindingFlags.NonPublic);
            field.SetValue(test, "Pawkata");
            Console.WriteLine("Name after the change : " + test.Name);


            Console.WriteLine();
            Console.WriteLine("Getting CTORs:");
            ConstructorInfo ctor = type.GetConstructor(new Type[] {typeof(string)});
            //object sb = ctor.Invoke(new object[] { "Pavel" }); => Console.WriteLine(((TestReflection)sb).Name);
            TestReflection sb = (TestReflection)ctor.Invoke(new object[] { "Pavel" });
            Console.WriteLine(sb.Name);
            // Same is the logic with methods -> GetMethod, Invoke ...

        }
    }
}

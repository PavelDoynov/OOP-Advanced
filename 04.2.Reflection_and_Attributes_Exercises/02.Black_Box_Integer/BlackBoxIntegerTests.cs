namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            //TODO put your reflection code here

            Type classType = typeof(BlackBoxInteger);
            BlackBoxInteger activator = (BlackBoxInteger)Activator.CreateInstance(classType, true);

            string cmd;
            while ((cmd = Console.ReadLine()) != "END")
            {
                string command = cmd.Split('_').ToArray().Take(1).First();
                int number = cmd.Split('_').ToArray().Skip(1).Take(1).Select(int.Parse).First();

                MethodInfo method = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                                             .First(m => m.Name == command);
                method.Invoke(activator, new object[] {number});

                FieldInfo field = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                                           .Where(f => f.Name == "innerValue").First();
                Console.WriteLine($"{field.GetValue(activator)}");

            }
        }
    }
}

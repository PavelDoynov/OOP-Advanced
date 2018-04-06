using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public static void PrintMethodsByAuthor()
    {
        Type classType = typeof(Program);
        MethodInfo[] methods = classType.GetMethods(BindingFlags.Static | BindingFlags.Instance 
                                                    | BindingFlags.Public);

        foreach (MethodInfo method in methods)
        {
            foreach (SoftUniAttribute attrs in method.GetCustomAttributes<SoftUniAttribute>())
            {
                Console.WriteLine($"{method.Name} is written by {attrs.Name}");
            }
        }
    }
}
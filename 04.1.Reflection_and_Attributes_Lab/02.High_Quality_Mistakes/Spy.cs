using System;
using System.Linq;
using System.Text;
using System.Reflection;

public class Spy
{
    public string StealFieldInfo (string className, params string[] fields)
    {
        Type typeClass = Type.GetType(className);
        FieldInfo[] currentFields = typeClass.GetFields(BindingFlags.Static | BindingFlags.Instance | 
                                                   BindingFlags.NonPublic | BindingFlags.Public);

        StringBuilder result = new StringBuilder();

        object classIstance = Activator.CreateInstance(typeClass, new object[] { });

        result.Append($"Class under investigation: {className}" + Environment.NewLine);

        foreach (FieldInfo field in currentFields.Where(f => fields.ToList().Contains(f.Name)))
        {
            result.AppendLine($"{field.Name} = {field.GetValue(classIstance)}");
        }

        return result.ToString().Trim();
    }

    public string AnalyzeAcessModifiers (string className)
    {
        Type classType = Type.GetType(className);

        FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] pubicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder result = new StringBuilder();

        fields.ToList().ForEach(f => result.AppendLine($"{f.Name} must be private!"));
        nonPublicMethods.Where(m => m.Name.StartsWith("get")).ToList().ForEach(m => result.AppendLine($"{m.Name} have to be public!"));
        pubicMethods.Where(m => m.Name.StartsWith("set")).ToList().ForEach(m => result.AppendLine($"{m.Name} have to be private!"));


        return result.ToString().Trim();
    }
}
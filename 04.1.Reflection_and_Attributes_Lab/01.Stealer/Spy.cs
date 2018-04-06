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
}
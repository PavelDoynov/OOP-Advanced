 namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            //TODO put your reflection code here

            Type classType = typeof(HarvestingFields);
            FieldInfo[] getFields = classType.GetFields(BindingFlags.Static | BindingFlags.Instance
                                                                | BindingFlags.NonPublic | BindingFlags.Public);

            string input;
            while ((input = Console.ReadLine()) != "HARVEST")
            {
                if (input == "private")
                {
                    getFields.Where(f => f.IsPrivate).ToList()
                             .ForEach(f => Console.WriteLine($"{GetFieldModifier(f)} {f.FieldType.Name} {f.Name}"));
                }
                else if (input == "protected")
                {
                    getFields.Where(f => f.IsFamily).ToList()
                             .ForEach(f => Console.WriteLine($"{GetFieldModifier(f)} {f.FieldType.Name} {f.Name}"));
                }
                else if (input == "public")
                {
                    getFields.Where(f => f.IsPublic).ToList()
                             .ForEach(f => Console.WriteLine($"{GetFieldModifier(f)} {f.FieldType.Name} {f.Name}"));
                }
                else if (input == "all")
                {
                    getFields.ToList()
                             .ForEach(f => Console.WriteLine($"{GetFieldModifier(f)} {f.FieldType.Name} {f.Name}"));
                }
            }
        }

        private static string GetFieldModifier(FieldInfo f)
        {
            if (f.IsFamily)
            {
                return "protected";
            }
            else if (f.IsPublic)
            {
                return "public";
            }
            else if (f.IsPrivate)
            {
                return "private";
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}

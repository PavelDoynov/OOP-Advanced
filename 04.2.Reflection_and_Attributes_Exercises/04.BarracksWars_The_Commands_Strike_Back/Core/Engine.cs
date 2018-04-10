namespace _03BarracksFactory.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4 - SOLVED !!!

        private string InterpredCommand(string[] data, string commandName)
        {
            string result = string.Empty;

            Assembly assembly = Assembly.GetCallingAssembly();
            Type commandType = assembly.GetTypes().First(t => t.Name.ToLower() == commandName + "command");

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            MethodInfo method = typeof(IExecutable).GetMethods().First();
            object[] ctorArgs = new object[] { data, this.repository, this.unitFactory };
            object activator = Activator.CreateInstance(commandType, ctorArgs);

            try
            {
                return (string)method.Invoke(activator, null);
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }
    }
}

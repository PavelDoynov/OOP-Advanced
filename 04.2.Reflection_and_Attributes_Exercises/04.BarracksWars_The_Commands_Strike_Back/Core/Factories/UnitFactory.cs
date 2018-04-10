namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {

        private const string NAMESPACE_OF_UNITS = "_03BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            //TODO: implement for Problem 3 - SOLVED !!!
            //Type typeUnit = Type.GetType($"{NAMESPACE_OF_UNITS}{unitType}");
            //return (IUnit)Activator.CreateInstance(typeUnit);

            try
            {
                return (IUnit)Activator.CreateInstance(Type.GetType($"{NAMESPACE_OF_UNITS}{unitType}"));
            }
            catch (ArgumentException)
            {
                throw new ArgumentException($"Invalid Unit Type - \"{unitType}\"!");
            }
        }
    }
}

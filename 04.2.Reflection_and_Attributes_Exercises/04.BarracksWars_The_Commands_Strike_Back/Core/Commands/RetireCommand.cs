using System;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            this.Repository.RemoveUnit(unitType);
            return $"{unitType} retired!";
            //try
            //{
            //    this.Repository.RemoveUnit(unitType);
            //    return $"{unitType} retired!";
            //}
            //catch (Exception ex)
            //{
            //    throw new ArgumentException("No such units in repository.");
            //}
        }
    }
}

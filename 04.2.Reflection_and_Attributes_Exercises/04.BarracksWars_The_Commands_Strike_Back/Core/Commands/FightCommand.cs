﻿using System;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class FightCommand : Command
    {
        public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return "";
        }
    }
}

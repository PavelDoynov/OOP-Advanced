using System;

public class Program
{

    public static void Main(string[] args)
    {

        IEnergyRepository energyRepository = new EnergyRepository();
        IHarvesterFactory factory = new HarvesterFactory();

        IHarvesterController harvesterControler = new HarverterController(energyRepository, factory);
        IProviderController providerController = new ProviderController(energyRepository);

        ICommandInterpreter command = new CommandInterpreter(harvesterControler, providerController);

        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();

        Engine engine = new Engine(command, reader, writer);
        engine.Run();
    }
}
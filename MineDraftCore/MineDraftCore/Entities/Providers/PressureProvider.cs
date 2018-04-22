using System;
public class PressureProvider : Provider
{
    private const double LowDurability = 300;
    private const int IncreaseEnergyOutput = 2;

    public PressureProvider(int id, double energyOutput) 
        : base(id, energyOutput)
    {
        this.EnergyOutput *= IncreaseEnergyOutput;
        this.Durability -= LowDurability;
    }
}
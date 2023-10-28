namespace Itmo.ObjectOrientedProgramming.Lab2.Ram;

public class Ram
{
    public Ram(string name, int availableMemory, int jedec, bool xmp, string formFactor, int ddr, int powerConsumption)
    {
        Name = name;
        AvailableMemory = availableMemory;
        Jedec = jedec;
        Xmp = xmp;
        FormFactor = formFactor;
        Ddr = ddr;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; init; }
    public int AvailableMemory { get; init; }
    public int Jedec { get; init; }
    public bool Xmp { get; init; }
    public string FormFactor { get; init; }
    public int Ddr { get; init; }
    public int PowerConsumption { get; init; }

    public Ram Clone()
    {
        return new Ram(Name, AvailableMemory, Jedec, Xmp, FormFactor, Ddr, PowerConsumption);
    }
}
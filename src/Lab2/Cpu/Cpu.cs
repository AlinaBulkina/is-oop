namespace Itmo.ObjectOrientedProgramming.Lab2.Cpu;

public class Cpu
{
    public Cpu(
        string name,
        int frequency,
        int coresNumber,
        string socket,
        bool videoCore,
        int supportedMemoryFrequencies,
        int tdp,
        int powerConsumption)
    {
        Name = name;
        Frequency = frequency;
        CoresNumber = coresNumber;
        Socket = socket;
        VideoCore = videoCore;
        SupportedMemoryFrequencies = supportedMemoryFrequencies;
        Tdp = tdp;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; init; }
    public int Frequency { get; init; }
    public int CoresNumber { get; init; }
    public string Socket { get; init; }
    public bool VideoCore { get; init; }
    public int SupportedMemoryFrequencies { get; init; }
    public int Tdp { get; init; }
    public int PowerConsumption { get; init; }

    public Cpu Clone()
    {
        return new Cpu(
            Name,
            Frequency,
            CoresNumber,
            Socket,
            VideoCore,
            SupportedMemoryFrequencies,
            Tdp,
            PowerConsumption);
    }
}
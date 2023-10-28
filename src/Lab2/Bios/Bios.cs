namespace Itmo.ObjectOrientedProgramming.Lab2.Bios;

public class Bios
{
    public Bios(string name, string availableCpu)
    {
        Name = name;
        AvailableCpu = availableCpu;
    }

    public string Name { get; init; }
    public string AvailableCpu { get; init; }

    public Bios Clone()
    {
        return new Bios(Name, AvailableCpu);
    }
}
namespace Itmo.ObjectOrientedProgramming.Lab2.Motherboard;

public class Motherboard
{
    public Motherboard(string name, string socket, string formFactor, string bios)
    {
        Name = name;
        Socket = socket;
        FormFactor = formFactor;
        Bios = bios;
    }

    public string Name { get; init; }
    public string Socket { get; init; }
    public string FormFactor { get; init; }
    public string Bios { get; init; }

    public Motherboard Clone()
    {
        return new Motherboard(Name, Socket, FormFactor, Bios);
    }
}
namespace Itmo.ObjectOrientedProgramming.Lab2.CoolingSystem;

public class CoolingSystem
{
    public CoolingSystem(string name, int size, string socket, int tdp)
    {
        Name = name;
        Size = size;
        Socket = socket;
        Tdp = tdp;
    }

    public string Name { get; init; }
    public int Size { get; init; }
    public string Socket { get; init; }
    public int Tdp { get; init; }

    public CoolingSystem Clone()
    {
        return new CoolingSystem(Name, Size, Socket, Tdp);
    }
}
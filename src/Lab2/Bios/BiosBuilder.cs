namespace Itmo.ObjectOrientedProgramming.Lab2.Bios;

public class BiosBuilder
{
    private string? _name;
    private string? _availableCpu;

    public BiosBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public BiosBuilder WithAvailableCpu(string availableCpu)
    {
        _availableCpu = availableCpu;
        return this;
    }

    public Bios Build()
    {
        return new Bios(_name, _availableCpu);
    }
}
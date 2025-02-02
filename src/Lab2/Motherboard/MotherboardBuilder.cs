namespace Itmo.ObjectOrientedProgramming.Lab2.Motherboard;

public class MotherboardBuilder
{
    private string? _name;
    private string? _socket;
    private string? _formFactor;
    private string? _bios;

    public MotherboardBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public MotherboardBuilder WithSocket(string socket)
    {
        _socket = socket;
        return this;
    }

    public MotherboardBuilder WithFormFactor(string formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public MotherboardBuilder WithBios(string bios)
    {
        _bios = bios;
        return this;
    }

    public Motherboard Build()
    {
        return new Motherboard(_name, _socket, _formFactor, _bios);
    }
}
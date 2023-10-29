namespace Itmo.ObjectOrientedProgramming.Lab2.Ram;

public class RamBuilder
{
    private string? _name;
    private int _availableMemory;
    private int _jedec;
    private bool _xmp;
    private string? _formFactor;
    private int _ddr;
    private int _powerConsumption;

    public RamBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public RamBuilder WithAvailableMemory(int availableMemory)
    {
        _availableMemory = availableMemory;
        return this;
    }

    public RamBuilder WithJedec(int jedec)
    {
        _jedec = jedec;
        return this;
    }

    public RamBuilder WithXmp()
    {
        _xmp = true;
        return this;
    }

    public RamBuilder WithFormFactor(string formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public RamBuilder WithDdr(int ddr)
    {
        _ddr = ddr;
        return this;
    }

    public RamBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public Ram Build()
    {
        return new Ram(_name, _availableMemory, _jedec, _xmp, _formFactor, _ddr, _powerConsumption);
    }
}
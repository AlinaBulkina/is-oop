namespace Itmo.ObjectOrientedProgramming.Lab2.Cpu;

public class CpuBuilder
{
    private string? _name;
    private int _frequency;
    private int _coresNumber;
    private string? _socket;
    private bool _videoCore;
    private int _supportedMemoryFrequencies;
    private int _tdp;
    private int _powerConsumption;

    public CpuBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public CpuBuilder WithFrequency(int frequency)
    {
        _frequency = frequency;
        return this;
    }

    public CpuBuilder WithCoresNumber(int coresNumber)
    {
        _coresNumber = coresNumber;
        return this;
    }

    public CpuBuilder WithSocket(string socket)
    {
        _socket = socket;
        return this;
    }

    public CpuBuilder WithVideoCore()
    {
        _videoCore = true;
        return this;
    }

    public CpuBuilder WithSupportedMemoryFrequencies(int supportedMemoryFrequencies)
    {
        _supportedMemoryFrequencies = supportedMemoryFrequencies;
        return this;
    }

    public CpuBuilder WithTdp(int tdp)
    {
        _tdp = tdp;
        return this;
    }

    public CpuBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public Cpu Build()
    {
        return new Cpu(
            _name,
            _frequency,
            _coresNumber,
            _socket,
            _videoCore,
            _supportedMemoryFrequencies,
            _tdp,
            _powerConsumption);
    }
}
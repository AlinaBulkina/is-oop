namespace Itmo.ObjectOrientedProgramming.Lab2.VideoCard;

public class VideoCardBuilder
{
    private string? _name;
    private int _height;
    private int _width;
    private int _memory;
    private int _frequency;
    private int _powerConsumption;

    public VideoCardBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public VideoCardBuilder WithHeight(int height)
    {
        _height = height;
        return this;
    }

    public VideoCardBuilder WithWidth(int width)
    {
        _width = width;
        return this;
    }

    public VideoCardBuilder WithMemory(int memory)
    {
        _memory = memory;
        return this;
    }

    public VideoCardBuilder WithFrequency(int frequency)
    {
        _frequency = frequency;
        return this;
    }

    public VideoCardBuilder WithPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public VideoCard Build()
    {
        return new VideoCard(_name, _height, _width, _memory, _frequency, _powerConsumption);
    }
}
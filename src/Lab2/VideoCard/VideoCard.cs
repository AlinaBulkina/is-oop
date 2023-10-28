namespace Itmo.ObjectOrientedProgramming.Lab2.VideoCard;

public class VideoCard
{
    public VideoCard(string name, int height, int width, int memory, int frequency, int powerConsumption)
    {
        Name = name;
        Height = height;
        Width = width;
        Memory = memory;
        Frequency = frequency;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; init; }
    public int Height { get; init; }
    public int Width { get; init; }
    public int Memory { get; init; }
    public int Frequency { get; init; }
    public int PowerConsumption { get; init; }

    public VideoCard Clone()
    {
        return new VideoCard(Name, Height, Width, Memory, Frequency, PowerConsumption);
    }
}
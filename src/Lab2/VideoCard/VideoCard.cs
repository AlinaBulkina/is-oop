using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.VideoCard;

public class VideoCard
{
    public VideoCard(string? name, int height, int width, int memory, int frequency, int powerConsumption)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

        if (height <= 0) throw new ArgumentOutOfRangeException(nameof(height));

        if (width <= 0) throw new ArgumentOutOfRangeException(nameof(width));

        if (memory <= 0) throw new ArgumentOutOfRangeException(nameof(memory));

        if (frequency <= 0) throw new ArgumentOutOfRangeException(nameof(frequency));

        if (powerConsumption <= 0) throw new ArgumentOutOfRangeException(nameof(powerConsumption));

        Name = name;
        Height = height;
        Width = width;
        Memory = memory;
        Frequency = frequency;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; }
    public int Height { get; }
    public int Width { get; }
    public int Memory { get; }
    public int Frequency { get; }
    public int PowerConsumption { get; }

    public VideoCard Clone()
    {
        return new VideoCard(Name, Height, Width, Memory, Frequency, PowerConsumption);
    }
}
namespace Itmo.ObjectOrientedProgramming.Lab2.Frame;

public class Frame
{
    public Frame(string name, int videoCardMaxHeight, int videoCardMaxWidth)
    {
        Name = name;
        VideoCardMaxHeight = videoCardMaxHeight;
        VideoCardMaxWidth = videoCardMaxWidth;
    }

    public string Name { get; init; }
    public int VideoCardMaxHeight { get; init; }
    public int VideoCardMaxWidth { get; init; }

    public Frame Clone()
    {
        return new Frame(Name, VideoCardMaxHeight, VideoCardMaxWidth);
    }
}
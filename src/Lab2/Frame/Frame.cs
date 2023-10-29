using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Frame;

public class Frame
{
    public Frame(string? name, int videoCardMaxHeight, int videoCardMaxWidth)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

        if (videoCardMaxHeight <= 0) throw new ArgumentOutOfRangeException(nameof(videoCardMaxHeight));

        if (videoCardMaxWidth <= 0) throw new ArgumentOutOfRangeException(nameof(videoCardMaxWidth));

        Name = name;
        VideoCardMaxHeight = videoCardMaxHeight;
        VideoCardMaxWidth = videoCardMaxWidth;
    }

    public string Name { get; }
    public int VideoCardMaxHeight { get; }
    public int VideoCardMaxWidth { get; }

    public Frame Clone()
    {
        return new Frame(Name, VideoCardMaxHeight, VideoCardMaxWidth);
    }
}
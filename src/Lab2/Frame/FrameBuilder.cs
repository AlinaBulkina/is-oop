using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Frame;

public class FrameBuilder
{
    private string? _name;
    private int _videoCardMaxHeight;
    private int _videoCardMaxWidth;

    public FrameBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public FrameBuilder WithVideoCardMaxHeight(int videoCardMaxHeight)
    {
        _videoCardMaxHeight = videoCardMaxHeight;
        return this;
    }

    public FrameBuilder WithVideoCardMaxWidth(int videoCardMaxWidth)
    {
        _videoCardMaxWidth = videoCardMaxWidth;
        return this;
    }

    public Frame Build()
    {
        if (_name is null)
        {
            throw new ArgumentNullException(nameof(_name));
        }

        if (_videoCardMaxHeight <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(_videoCardMaxHeight));
        }

        if (_videoCardMaxWidth <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(_videoCardMaxWidth));
        }

        return new Frame(_name, _videoCardMaxHeight, _videoCardMaxWidth);
    }
}
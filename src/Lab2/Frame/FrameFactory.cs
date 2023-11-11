using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.Frame;

public class FrameFactory : IFactory<Frame>
{
    private readonly ICollection<Frame> _frameList;

    public FrameFactory(ICollection<Frame> frameList)
    {
        _frameList = frameList;
    }

    public Frame CreateByName(string name)
    {
        Frame frame = _frameList.FirstOrDefault(frame => frame.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
                      throw new ArgumentException("Wrong frame name");
        return frame.Clone();
    }
}
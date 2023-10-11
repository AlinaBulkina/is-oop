using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environment;

public class NitrineNebula : EnvironmentBase
{
    public NitrineNebula(int spaceWhaleCount)
    {
        if (SpaceWhaleCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(spaceWhaleCount));
        }

        SpaceWhaleCount = spaceWhaleCount;
    }
}
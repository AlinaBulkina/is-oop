using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environment;

public class NitrineNebula : EnvironmentBase
{
    public NitrineNebula(int spaceWhaleCount)
    {
        if (spaceWhaleCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(spaceWhaleCount));
        }

        SpaceWhales = new SpaceWhale(spaceWhaleCount);

        PathLength = 0;
    }
}
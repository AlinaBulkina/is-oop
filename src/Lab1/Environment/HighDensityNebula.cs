using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environment;

public class HighDensityNebula : EnvironmentBase
{
    public HighDensityNebula(int flareCount, int pathLength)
    {
        if (flareCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(flareCount));
        }

        Flares = new Flare(flareCount);
        if (pathLength < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(pathLength));
        }

        PathLength = pathLength;
    }
}
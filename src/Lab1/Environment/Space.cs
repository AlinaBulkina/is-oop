using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environment;

public class Space : EnvironmentBase
{
    public Space(int asteroidCount, int meteoriteCount)
    {
        if (asteroidCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(asteroidCount));
        }

        if (meteoriteCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(meteoriteCount));
        }

        AsteroidCount = asteroidCount;
        MeteoriteCount = meteoriteCount;
    }
}
using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

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

        Asteroids = new Asteroid(asteroidCount);
        Meteorites = new Meteorite(meteoriteCount);
        PathLength = 0;
    }
}
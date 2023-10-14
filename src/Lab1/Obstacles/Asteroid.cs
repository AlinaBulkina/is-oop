using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class Asteroid : ObstacleBase
{
    public Asteroid(int asteroidCount)
    {
        if (asteroidCount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(asteroidCount));
        }

        Damage = 10 * asteroidCount;
    }
}
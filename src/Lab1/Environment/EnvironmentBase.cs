using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environment;

public class EnvironmentBase
{
    public Meteorite? Meteorites { get; init; }
    public Asteroid? Asteroids { get; init; }
    public Flare? Flares { get; init; }
    public SpaceWhale? SpaceWhales { get; init; }

    public int PathLength { get; init; }
}
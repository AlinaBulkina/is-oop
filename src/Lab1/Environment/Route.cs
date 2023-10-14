using Itmo.ObjectOrientedProgramming.Lab1.Environment;
using Microsoft.VisualBasic;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class Route
{
    public Collection RouteParts { get; private set; } = new();

    public void AddPart(EnvironmentBase newPart)
    {
        RouteParts.Add(newPart);
    }
}
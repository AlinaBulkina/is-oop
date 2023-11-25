using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public interface IConsoleDriver : IDisplayDriver
{
    void SetColor(ConsoleColor color);
}
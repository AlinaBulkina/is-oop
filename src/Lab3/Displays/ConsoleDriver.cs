using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class ConsoleDriver : IConsoleDriver
{
    public ConsoleColor Color { get; private set; } = ConsoleColor.Black;

    public string Text { get; private set; } = string.Empty;

    public void SetColor(ConsoleColor color)
    {
        Color = color;
    }

    public void SetText(string text)
    {
        Text = text;
    }
}
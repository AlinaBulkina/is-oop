using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class DisplayDriver
{
    public ConsoleColor Color { get; set; } = ConsoleColor.Black;

    public string Text { get; set; } = string.Empty;

    public void SetColor(ConsoleColor color)
    {
        Color = color;
    }

    public void SetText(string text)
    {
        Text = text;
    }
}
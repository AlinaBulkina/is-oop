using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class Display
{
    public DisplayDriver DisplayDriver { get; set; } = new DisplayDriver();

    public void Print()
    {
        Console.Clear();
        Console.ForegroundColor = DisplayDriver.Color;
        Console.WriteLine(DisplayDriver.Text);
        Console.ResetColor();
    }
}
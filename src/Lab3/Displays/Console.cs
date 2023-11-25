namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class Console : IDisplay
{
    public ConsoleDriver ConsoleDriver { get; set; } = new ConsoleDriver();

    public void Print()
    {
        System.Console.Clear();
        System.Console.ForegroundColor = ConsoleDriver.Color;
        System.Console.WriteLine(ConsoleDriver.Text);
        System.Console.ResetColor();
    }
}
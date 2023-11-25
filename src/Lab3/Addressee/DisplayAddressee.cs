using System;
using Console = Itmo.ObjectOrientedProgramming.Lab3.Displays.Console;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class DisplayAddressee : IAddressee
{
    private readonly Console _console = new();

    public void ReceiveMessage(Message message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        _console.ConsoleDriver.SetText(message.Body);
    }
}
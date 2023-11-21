using System;
using Itmo.ObjectOrientedProgramming.Lab3.Displays;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class DisplayAddressee : IAddressee
{
    private readonly Display _display = new();

    public void ReceiveMessage(Message message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        _display.DisplayDriver.SetText(message.Body);
    }
}
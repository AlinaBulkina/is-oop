using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers;

public class SomeMessenger : ISomeMessenger
{
    private readonly ICollection<string> _messages = new List<string>();

    public void ReceiveMessage(string message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        _messages.Add(message);
    }

    public void PrintMessages()
    {
        Console.WriteLine("Messenger: ");
        foreach (string message in _messages)
        {
            Console.WriteLine(message);
        }
    }
}
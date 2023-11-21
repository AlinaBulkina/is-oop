using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers;

public class SomeMessenger : IMessenger
{
    private readonly ICollection<Message> _messages = new List<Message>();

    public void ReceiveMessage(Message message)
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
        foreach (Message message in _messages)
        {
            Console.WriteLine(message.Body);
        }
    }
}
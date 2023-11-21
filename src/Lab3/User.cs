using System;
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class User
{
    private readonly ICollection<UserMessage> _messages = new List<UserMessage>();

    public void ReceiveMessage(UserMessage userMessage)
    {
        if (userMessage is null)
        {
            throw new ArgumentNullException(nameof(userMessage));
        }

        _messages.Add(userMessage);
    }

    public void MarkMessageAsRead(UserMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        foreach (UserMessage localMessage in _messages)
        {
            if (localMessage.Message != message.Message) continue;
            if (localMessage.IsRead)
            {
                throw new ArgumentException("Trying to mark already marked message");
            }

            localMessage.IsRead = true;
            break;
        }
    }

    public bool CheckIfMessageIsRead(UserMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        foreach (UserMessage localMessage in _messages)
        {
            if (localMessage != message) continue;
            return localMessage.IsRead;
        }

        return false;
    }
}
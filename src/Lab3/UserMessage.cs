using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class UserMessage
{
    public UserMessage(Message? message)
    {
        Message = message ?? throw new ArgumentNullException(nameof(message));
    }

    public Message Message { get; init; }
    public bool IsRead { get; set; }
}
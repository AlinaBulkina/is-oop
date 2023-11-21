using System;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Message
{
    public Message(string? header, string? body, int importanceLevel)
    {
        if (importanceLevel < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(importanceLevel));
        }

        Header = header ?? throw new ArgumentNullException(nameof(header));
        Body = body ?? throw new ArgumentNullException(nameof(body));
        ImportanceLevel = importanceLevel;
    }

    public string Header { get; init; }
    public string Body { get; init; }
    public int ImportanceLevel { get; init; }
}
using System;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MessengerTests
{
    [Fact]
    public void ReceiveMessageIsUnread()
    {
        var firstUser = new User();
        var message = new Message("Greetings", "Hello sweetie", 1);
        var userMessage = new UserMessage(message);
        firstUser.ReceiveMessage(userMessage);

        Assert.False(firstUser.CheckIfMessageIsRead(userMessage));
    }

    [Fact]
    public void ChangeMessageStatus()
    {
        var firstUser = new User();
        var message = new Message("Greetings", "Hello sweetie", 1);
        var userMessage = new UserMessage(message);
        firstUser.ReceiveMessage(userMessage);

        Assert.False(firstUser.CheckIfMessageIsRead(userMessage));
        firstUser.MarkMessageAsRead(userMessage);
        Assert.True(firstUser.CheckIfMessageIsRead(userMessage));
    }

    [Fact]
    public void MarkAsReadAlreadyMarkedMessage()
    {
        var firstUser = new User();
        var message = new Message("Greetings", "Hello sweetie", 1);
        var userMessage = new UserMessage(message);
        firstUser.ReceiveMessage(userMessage);

        firstUser.MarkMessageAsRead(userMessage);
        Assert.True(firstUser.CheckIfMessageIsRead(userMessage));
        Assert.Throws<ArgumentException>(() => firstUser.MarkMessageAsRead(userMessage));
    }
}
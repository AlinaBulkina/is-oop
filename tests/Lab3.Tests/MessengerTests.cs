using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee.Filters;
using Itmo.ObjectOrientedProgramming.Lab3.Messengers;
using Moq;
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

    [Fact]
    public void SendToAddressee()
    {
        var someMessenger = new Mock<IAddressee>();
        var addressee = new ProxyAddressee(someMessenger.Object, new ImportanceFilter(2));
        var message = new Message("Hi", "hello", 1);
        addressee.ReceiveMessage(message);
        someMessenger.Verify(mock => mock.ReceiveMessage(message), Times.Never);
    }

    [Fact]
    public void SendToMessenger()
    {
        var someMessenger = new Mock<ISomeMessenger>();
        var adapter = new Mock<SomeMessengerAdapter>(someMessenger.Object);
        var addressee = new MessengerAddressee(adapter.Object);
        var message = new Message("Hi", "hello", 3);
        addressee.ReceiveMessage(message);
        someMessenger.Verify(mock => mock.ReceiveMessage("hello"), Times.Once);
    }
}
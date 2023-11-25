using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers;

public class SomeMessengerAdapter : IMessenger
{
    private readonly ISomeMessenger _someMessenger;

    public SomeMessengerAdapter(ISomeMessenger someMessenger)
    {
        _someMessenger = someMessenger ?? throw new ArgumentNullException(nameof(someMessenger));
    }

    public void ReceiveMessage(Message message)
    {
        if (message is null) throw new ArgumentNullException(nameof(message));
        _someMessenger.ReceiveMessage(message.Body);
    }

    public void PrintMessages()
    {
        _someMessenger.PrintMessages();
    }
}
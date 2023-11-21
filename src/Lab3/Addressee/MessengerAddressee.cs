using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messengers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class MessengerAddressee : IAddressee
{
    public MessengerAddressee(IMessenger messenger)
    {
        Messenger = messenger ?? throw new ArgumentNullException(nameof(messenger));
    }

    public IMessenger Messenger { get; init; }

    public void ReceiveMessage(Message message)
    {
        if (message is null) throw new ArgumentNullException(nameof(message));

        Messenger.ReceiveMessage(message);
    }
}
using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Topic
{
    public Topic(string name, IAddressee addressee)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Addressee = addressee ?? throw new ArgumentNullException(nameof(addressee));
    }

    public string Name { get; set; }

    private IAddressee Addressee { get; set; }

    public void SendMessage(Message message)
    {
        if (message is null) throw new ArgumentNullException(nameof(message));
        Addressee.ReceiveMessage(message);
    }
}
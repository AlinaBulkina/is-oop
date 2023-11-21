using System;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class GroupAddressee : IAddressee
{
    public GroupAddressee(Collection<IAddressee> addressees)
    {
        Addressees = addressees ?? throw new ArgumentNullException(nameof(addressees));
    }

    public Collection<IAddressee> Addressees { get; }

    public void ReceiveMessage(Message message)
    {
        if (message is null) throw new ArgumentNullException(nameof(message));
        foreach (IAddressee addressee in Addressees)
        {
            addressee.ReceiveMessage(message);
        }
    }
}
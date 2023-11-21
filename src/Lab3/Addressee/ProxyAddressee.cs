using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class ProxyAddressee : IAddressee
{
    public ProxyAddressee(IAddressee addressee, int minImportanceLevel = 3)
    {
        Addressee = addressee ?? throw new ArgumentNullException(nameof(addressee));
        MinImportanceLevel = minImportanceLevel;
    }

    public int MinImportanceLevel { get; init; }
    private IAddressee Addressee { get; init; }

    public void ReceiveMessage(Message message)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));

        if (message.ImportanceLevel >= MinImportanceLevel)
        {
            Addressee.ReceiveMessage(message);
        }
    }
}
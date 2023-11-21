using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class LoggerAddressee : IAddressee
{
    private readonly IAddressee _addressee;

    private readonly ILogger _logger;

    public LoggerAddressee(IAddressee addressee, ILogger logger)
    {
        _addressee = addressee ?? throw new ArgumentNullException(nameof(addressee));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public void ReceiveMessage(Message message)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));

        _logger.Log(ToLogMessage(message));
        _addressee.ReceiveMessage(message);
    }

    private static string ToLogMessage(Message message)
    {
        return "Message has received: " + message.Body;
    }
}
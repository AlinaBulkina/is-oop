namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers;

public interface IMessenger
{
    void ReceiveMessage(Message message);
    void PrintMessages();
}
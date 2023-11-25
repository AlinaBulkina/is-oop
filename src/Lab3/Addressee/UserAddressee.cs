namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class UserAddressee : IAddressee
{
    public UserAddressee(User user)
    {
        User = user;
    }

    private User User { get; }

    public void ReceiveMessage(Message message)
    {
        var userMessage = new UserMessage(message);
        User.ReceiveMessage(userMessage);
    }
}
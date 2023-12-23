namespace Lab5.Application.Contracts.Users;

public abstract record LoginResult
{
    private LoginResult() { }

#pragma warning disable CA1034
    public sealed record Success : LoginResult;
    public sealed record WrongAccountNumberOrPin : LoginResult;
    public sealed record WrongSystemPassword : LoginResult;
#pragma warning restore CA1034
}

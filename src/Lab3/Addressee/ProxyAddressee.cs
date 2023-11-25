using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressee.Filters;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee;

public class ProxyAddressee : IAddressee
{
    private readonly IFilter _filter;

    private readonly IAddressee _addressee;

    public ProxyAddressee(IAddressee addressee, IFilter filer)
    {
        _addressee = addressee ?? throw new ArgumentNullException(nameof(addressee));
        _filter = filer ?? throw new ArgumentNullException(nameof(filer));
    }

    public void ReceiveMessage(Message message)
    {
        if (_filter.Filter(message))
        {
            _addressee.ReceiveMessage(message);
        }
    }
}
namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee.Filters;

public interface IFilter
{
    bool Filter(Message message);
}
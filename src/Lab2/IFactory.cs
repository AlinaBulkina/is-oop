namespace Itmo.ObjectOrientedProgramming.Lab2;

public interface IFactory<T>
{
    T? CreateByName(string name);
}
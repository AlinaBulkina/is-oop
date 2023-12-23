namespace Lab5.Presentation.Console;

public interface IScenario
{
    string Name { get; }

    Task<Task> Run();
}
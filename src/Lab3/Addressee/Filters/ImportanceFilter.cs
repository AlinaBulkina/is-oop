using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressee.Filters;

public class ImportanceFilter : IFilter
{
    private readonly int _minImportanceLevel;

    public ImportanceFilter(int minImportanceLevel)
    {
        _minImportanceLevel = minImportanceLevel;
    }

    public bool Filter(Message message)
    {
        if (message == null) throw new ArgumentNullException(nameof(message));
        return message.ImportanceLevel >= _minImportanceLevel;
    }
}
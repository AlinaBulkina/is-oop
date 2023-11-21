using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab3;

public class MessageDistributionSystem
{
    private readonly Collection<Topic> _topics = new Collection<Topic>();

    public void AddTopic(Topic topic)
    {
        if (topic is null) throw new ArgumentNullException(nameof(topic));
        _topics.Add(topic);
    }

    public void DeleteTopic(string name)
    {
        if (name is null) throw new ArgumentNullException(nameof(name));

        _topics.Remove(_topics.FirstOrDefault(
                           topic => topic.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                       ?? throw new ArgumentException("Wrong topic name"));
    }

    public void SendMessage(Message message, string topicName)
    {
        if (message is null) throw new ArgumentNullException(nameof(message));
        if (topicName is null) throw new ArgumentNullException(nameof(topicName));

        Topic topic = _topics.FirstOrDefault(
                          topic => topic.Name.Equals(topicName, StringComparison.OrdinalIgnoreCase))
                      ?? throw new ArgumentException("Wrong topic name");
        topic.SendMessage(message);
    }
}
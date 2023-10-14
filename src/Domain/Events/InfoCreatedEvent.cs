using Domain.Common;
using Domain.Entities;

namespace Domain.Events;

public class InfoCreatedEvent : BaseEvent
{
    public Info Item { get; }
    public InfoCreatedEvent(Info item)
    {
        Item = item;
    }
}

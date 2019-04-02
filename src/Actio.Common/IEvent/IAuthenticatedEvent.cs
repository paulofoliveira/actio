using System;

namespace Actio.Common.IEvent
{
    public interface IAuthenticatedEvent : IEvent
    {
        Guid UserId { get; }
    }
}

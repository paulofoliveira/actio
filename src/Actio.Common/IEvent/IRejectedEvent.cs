using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.IEvent
{
    public interface IRejectedEvent : IEvent
    {
        string Reason { get; }
        string Code { get; }
    }
}

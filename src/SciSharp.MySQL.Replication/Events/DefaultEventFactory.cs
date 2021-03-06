using System;
using System.Buffers;

namespace SciSharp.MySQL.Replication
{

    class DefaultEventFactory<TEventType> : ILogEventFactory
        where TEventType : LogEvent, new()
    {
        public LogEvent Create(object context)
        {
            return new TEventType();
        }
    }
}

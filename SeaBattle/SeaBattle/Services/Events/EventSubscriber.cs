using System;

namespace SeaBattle.Services.Events
{
    public class EventSubscriber : IDisposable
    {
        private readonly Action<EventSubscriber> _action;

        public Type MessageType { get; }

        public EventSubscriber(Type messageType, Action<EventSubscriber> action)
        {
            MessageType = messageType;
            _action = action;
        }

        public void Dispose()
        {
            _action?.Invoke(this);
        }
    }
}

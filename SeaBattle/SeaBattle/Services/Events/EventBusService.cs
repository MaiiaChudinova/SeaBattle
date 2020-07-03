using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace SeaBattle.Services.Events
{
    public class EventBusService
    {
        private ConcurrentDictionary<EventSubscriber, Func<IEvent, Task>> _subscribers;

        public EventBusService()
        {
            _subscribers = new ConcurrentDictionary<EventSubscriber, Func<IEvent, Task>>();
        }

        public IDisposable Subscribe<T>(Func<T, Task> handler) where T : IEvent
        {
            var disposer = new EventSubscriber(typeof(T), s => _subscribers.TryRemove(s, out var _));

            _subscribers.TryAdd(disposer, (item) => handler((T)item));

            return disposer;
        }

        public async Task Publish<T>(T message) where T : IEvent
        {
            var messageType = typeof(T);

            var handlers = _subscribers
                .Where(s => s.Key.MessageType == messageType)
                .Select(s => s.Value(message));

            await Task.WhenAll(handlers);
        }
    }
}

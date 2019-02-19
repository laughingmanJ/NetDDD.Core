using System.Threading.Tasks;

namespace NetDDD.Core.Contracts
{
    /// <summary>
    /// Represents a domain event dispatcher for notifying registered event handlers.
    /// </summary>
    public interface IDomainEventDispatcher
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="event"></param>
        /// <returns></returns>
        Task Raise<T>(T @event)
            where T : IDomainEvent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        void Register(IDomainEventHandler handler);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        void Unregister(IDomainEventHandler handler);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handlerName"></param>
        /// <returns></returns>
        bool IsRegistered(string handlerName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        bool IsRegistered(IDomainEventHandler handler);
    }
}

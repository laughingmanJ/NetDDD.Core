using NetDDD.Core.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace NetDDD.Core.Bases
{
    /// <summary>
    /// Base class for domain entity object.
    /// </summary>
    /// <typeparam name="T">The type of the unique identifier</typeparam>
    public abstract class Entity<T> : IEntity<T>
    {
        // Collection of domain events for the entity.
        private IList<IDomainEvent> _domainEvents = new List<IDomainEvent>();

        /// <summary>
        /// Gets the identity of the entity.
        /// </summary>
        public T Id { get; protected set; }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var other = obj as Entity<T>;
            return Id.Equals(other.Id);
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            var hash = 13;
            hash = (hash * 7) + Id.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Overloads the equality operator for the entity object.
        /// </summary>
        /// <param name="x">First object.</param>
        /// <param name="y">Second object.</param>
        /// <returns>True if both objects are equal.</returns>
        public static bool operator ==(Entity<T> x, Entity<T> y)
        {
            if (x is null)
            {
                return y is null;
            }

            return x.Equals(y);
        }


        /// <summary>
        /// Overloads the inequality operator for the entity object.
        /// </summary>
        /// <param name="x">First object.</param>
        /// <param name="y">Second object.</param>
        /// <returns>True if both objects are not equal.</returns>
        public static bool operator !=(Entity<T> x, Entity<T> y)
        {
            return !(x == y);
        }

        /// <summary>
        /// Adds a domain event to the collection of events for the entity.
        /// </summary>
        /// <param name="event">A domain event.</param>
        protected void AddDomainEvent(DomainEvent @event)
        {
            _domainEvents.Add(@event);
        }

        /// <summary>
        /// Gets the domain events within the entity.
        /// </summary>
        /// <returns>A collection of domain events.</returns>
        IEnumerable<IDomainEvent> IEntity<T>.GetDomainEvents()
        {
            var events = _domainEvents.ToList();
            _domainEvents.Clear();
            return events;
        }
    }
}

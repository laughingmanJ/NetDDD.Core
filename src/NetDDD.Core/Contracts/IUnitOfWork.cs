using System;


namespace NetDDD.Core.Contracts
{
    /// <summary>
    /// Represents a unit of work in the domain.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commits all transactions done by the domain repositories behind the scenes.
        /// </summary>
        void Commit();

        /// <summary>
        /// Explicit rollback of the transactions done within the unit of work.
        /// </summary>
        void Rollback();
    }
}

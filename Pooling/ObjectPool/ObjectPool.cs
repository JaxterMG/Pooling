// SPDX-License-Identifier: MIT
// © 2024 JaxterMG <eugeny.craevsky@gmail.com>

namespace JaxterMG.Pooling.ObjectPool
{
	/// <summary>
	/// Abstract base class for an object pool.
	/// </summary>
	/// <typeparam name="T">The type of objects to be pooled.</typeparam>
	public abstract class ObjectPool<T> : IPool<T> where T : class
	{
		/// <summary>
		/// Queue to store available objects.
		/// </summary>
		protected Queue<T> _pool = new Queue<T>();

		/// <summary>
		/// Retrieves an object from the pool. If the pool is empty, a new object is created.
		/// </summary>
		/// <returns>An object of type <typeparamref name="T"/>.</returns>
		public virtual T Get()
		{
			return _pool.Count > 0 ? _pool.Dequeue() : CreateNew();
		}

		/// <summary>
		/// Returns an object to the pool.
		/// </summary>
		/// <param name="item">The object to return to the pool.</param>
		public virtual void Return(T item)
		{
			_pool.Enqueue(item);
		}

		/// <summary>
		/// Creates a new object of type <typeparamref name="T"/>.
		/// This method must be implemented by derived classes.
		/// </summary>
		/// <returns>A new object of type <typeparamref name="T"/>.</returns>
		protected abstract T CreateNew();
	}
}
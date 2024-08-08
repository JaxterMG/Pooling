// SPDX-License-Identifier: MIT
// © 2024 JaxterMG <eugeny.craevsky@gmail.com>

namespace JaxterMG.Pooling.ObjectPool
{
	public interface IPool<T>
	{
		T Get();
		void Return(T item);
	}
}
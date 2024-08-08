// SPDX-License-Identifier: MIT
// © 2024 JaxterMG <eugeny.craevsky@gmail.com>

using JaxterMG.Pooling.ObjectPool;

namespace JaxterMG.Pooling.Examples
{
	public class ExamplePool : ObjectPool<ExampleObject>
	{
		public int Count => _pool.Count;
		protected override ExampleObject CreateNew()
		{
			return new ExampleObject();
		}
	}
}
using JaxterMG.Pooling.Examples;

namespace Pooling.UnitTests
{
	public class ExamplePoolTests
	{
		private ExamplePool _pool;

		[SetUp]
		public void Setup()
		{
			_pool = new ExamplePool();
		}

		[Test]
		public void TestGetNewObject()
		{
			var obj = _pool.Get();
			Assert.IsNotNull(obj);
		}

		[Test]
		public void TestReturnObject()
		{
			var obj = _pool.Get();
			_pool.Return(obj);
			Assert.AreEqual(1, _pool.Count);
		}

		[Test]
		public void TestReuseObject()
		{
			var obj1 = _pool.Get();
			obj1.Name = "Object 1";
			_pool.Return(obj1);

			var obj2 = _pool.Get();
			Assert.AreEqual("Object 1", obj2.Name);
		}
	}
}
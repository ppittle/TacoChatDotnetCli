using System;
using NUnit.Framework;

namespace TacoChat.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine(nameof(Test1));
            Assert.Pass();
        }
    }
}
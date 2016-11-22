using System;
using Xunit;
using Xunit.Should;

namespace LearnIoc.Test
{
    public class LearnXUnit
    {
        public LearnXUnit()
        {
            Console.WriteLine("开始");
        }

        [Fact]
        public void Test()
        {
            Assert.Equal(3, Math.Max(3, 2));
            Console.WriteLine("使用Fact");
        }
    }
}

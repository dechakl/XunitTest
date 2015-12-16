using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitTest
{
    public class TestXunit
    {

        [Fact]
        public void PassingTest()
        {
            var a = 4;
            Assert.Equal(4, a);
        }
    }
}

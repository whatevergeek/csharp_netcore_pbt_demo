using System.Collections.Generic;
using Xunit;

namespace csharp_netcore_pbt_demo
{
    public class ArithmeticExampleBasedTest
    {
        IEnumerable<string> GetNames()
        {
            string[] names =
            {
                "Archimedes", "Pythagoras", "Euclid", "Socrates", "Plato"
            };

            foreach (var name in names[1..^0])
            {
                yield return name;
            }
        }

        [Fact]
        public void TestMultiplyUsingExample1()
        {
            int expected = 6;
            int actual = Arithmetic.Multiply(2, 3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyUsingExample2()
        {
            int expected = 20;
            int actual = Arithmetic.Multiply(4, 5);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 5, 20)]
        public void TestMultiplyUsingExample1And2(int factor1, int factor2, int expected)
        {
            int actual = Arithmetic.Multiply(factor1, factor2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCSharp8()
        {
            Assert.Equal("Pythagoras, Euclid, Socrates, Plato", string.Join(", ", GetNames()));
        }
    }
}

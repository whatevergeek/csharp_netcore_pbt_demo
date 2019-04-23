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
            Assert.Equal("Pythagoras, Euclid, Socrates, Plato", string.Join(", ", GetNames()));
        }
    }
}

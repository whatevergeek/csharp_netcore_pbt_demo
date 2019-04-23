using System.Collections.Generic;
using Xunit;
using static csharp_netcore_pbt_demo.Arithmetic;
using System.Linq;

namespace csharp_netcore_pbt_demo
{
    public class ArithmeticPropertyBasedTestWithPredeterminedInputs
    {
        [Theory]
        [InlineData(2, 3)]
        [InlineData(4, 5)]
        public void TestMultiplyCommutativeProperty(int factor1, int factor2) =>
            Assert.Equal(Multiply(factor1, factor2), Multiply(factor2, factor1));

        [Theory]
        [InlineData(2, 3, 4)]
        [InlineData(4, 5, 6)]
        public void TestMultiplyAssociativeProperty(int factor1, int factor2, int factor3) =>
            Assert.Equal(Multiply(factor1, Multiply(factor2, factor3)),
                Multiply(Multiply(factor1, factor2), factor3));


        public static IEnumerable<object[]> GetPredeterminedFactorList() =>
            Enumerable.Range(1, 100).Select(f => new object[] { f });
            
        [Theory]
        [MemberData(nameof(GetPredeterminedFactorList))]
        public void TestMultiplyIdentityProperty(int factor) =>
            Assert.Equal(Multiply(factor, 1), factor);

        [Theory]
        [InlineData(2, 3, 4)]
        [InlineData(4, 5, 6)]
        public void TestMultiplyDistributiveProperty(int factor1, int factor2, int factor3) =>
            Assert.Equal(Multiply(factor1, (factor2 + factor3)),
                Multiply(factor1, factor2) + Multiply(factor1, factor3));
    }
}

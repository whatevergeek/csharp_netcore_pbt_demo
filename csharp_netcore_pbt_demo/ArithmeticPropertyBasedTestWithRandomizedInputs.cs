using Xunit;
using static csharp_netcore_pbt_demo.Arithmetic;
using FsCheck.Xunit;

namespace csharp_netcore_pbt_demo
{
    public class ArithmeticPropertyBasedTestWithRandomizedInputs
    {
        [Property]
        public void TestMultiplyCommutativeProperty(int factor1, int factor2) =>
            Assert.Equal(Multiply(factor1, factor2), Multiply(factor2, factor1));

        [Property]
        public void TestMultiplyAssociativeProperty(int factor1, int factor2, int factor3) =>
            Assert.Equal(Multiply(factor1, Multiply(factor2, factor3)),
                Multiply(Multiply(factor1, factor2), factor3));

        [Property]
        public void TestMultiplyIdentityProperty(int factor) =>
            Assert.Equal(Multiply(factor, 1), factor);

        [Property]
        public void TestMultiplyDistributiveProperty(int factor1, int factor2, int factor3) =>
            Assert.Equal(Multiply(factor1, (factor2 + factor3)),
                Multiply(factor1, factor2) + Multiply(factor1, factor3));
    }
}

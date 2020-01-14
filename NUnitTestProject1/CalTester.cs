using CalcNameSpace.HelloWorld;
using NUnit.Framework;

namespace Calc.Test.CalcNameSpace
{
    [TestFixture]
    public class CalcDivideTest
    {
        private CalculatorMain getCalcDivide;

        [SetUp]
        public void Setup()
        {
            getCalcDivide = new CalculatorMain();
        }

        [TestCase(12, 6, 2)]
        [TestCase(10, 5, 2)]
        //[TestCase(11, 1, 1111)]
        public void TestCalcTest(int a, int b, int expected)
        {
            var returnedValue = getCalcDivide.CalculatorDivider(a, b);

            // act
            //Assert.AreEqual( a, b / c );
            Assert.AreEqual(expected, returnedValue);
        }
    }
}
using CalcNameSpace.HelloWorld;
using NUnit.Framework;

namespace Calc.Test.CalcNameSpace
{
    [TestFixture]
    public class CalcDivideTest
    {
        private CalculatorMain getCalcDivide;

        [SetUp]
        public void Setup() => getCalcDivide = new CalculatorMain();

        [TestCase(12, 6, 2)]
        [TestCase(10, 5, 2)] 
        public void TestCalcTest(int a, int b, int expected)
        {
            //arrange
            // act 
            var returnedValue = getCalcDivide.CalculatorDivider(a, b);           
            //assert
            Assert.AreEqual(expected, returnedValue);
        }
         
        [TestCase(11, 1, 1111)]
        public void TestCalcTestNotEqual(int a, int b, int expected)
        {
            //arrange
            // act 
            var returnedValue = getCalcDivide.CalculatorDivider(a, b);
            //assert
            Assert.AreNotEqual(expected, returnedValue);
        }
    }
}
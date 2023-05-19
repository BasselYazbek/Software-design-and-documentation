using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CorrectWeightCalculator
{
    [TestClass]
    public class MSUnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            //Arrange
            WeightCalculatorClass weightCalculatorClass = new WeightCalculatorClass(180, 'm');

            WeightCalculatorClass weightCalculatorClass1 = new WeightCalculatorClass(162, 'f');

            //Act
            double actual = weightCalculatorClass.GetIdealWeight();
            double expected = 72.5;

            double actual1 = weightCalculatorClass1.GetIdealWeight();
            double expected1 = 56;

            //Assert
            Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected1, actual1);
        }
    }
}

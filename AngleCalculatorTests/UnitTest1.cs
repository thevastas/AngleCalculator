using AngleCalculations;

namespace AngleCalculatorTests
{
    [TestClass]
    public class AngleTests
    {
        [TestMethod]
        public void CalculatesTheCorrectAngle()
        {
            AngleCalculator anglecalculator = new AngleCalculator();
            int angle = anglecalculator.CalculateAngle(0, 0);

            Assert.AreEqual(0, anglecalculator.CalculateAngle(0, 0));
            Assert.AreEqual(15, anglecalculator.CalculateAngle(6, 30));
            Assert.AreEqual(5, anglecalculator.CalculateAngle(23, 59));

        }
    }
}
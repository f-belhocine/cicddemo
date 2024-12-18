namespace GestionConcoursApp.Controllers.Tests
{
    [TestClass()]
    public class CalculatorControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            CalculatorController calculatorController = new CalculatorController();

            int a = 10;
            int b = 20;

            int expected = 30;


            var actual = calculatorController.Add(a, b);

            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void SubstractTest()
        {
            CalculatorController calculatorController = new CalculatorController();

            int a = 10;
            int b = 20;

            int expected = -10;


            var actual = calculatorController.Substract(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
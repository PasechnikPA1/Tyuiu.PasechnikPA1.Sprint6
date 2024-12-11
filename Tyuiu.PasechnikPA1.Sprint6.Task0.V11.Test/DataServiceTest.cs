using Tyuiu.PasechnikPA1.Sprint6.Task0.V11.Lib;
namespace Tyuiu.PasechnikPA1.Sprint6.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 18.4;
            Assert.AreEqual(wait, res);
        }
    }
}

using Tyuiu.skirnevskyBR.Sprint6.Task0.V16.Lib;
namespace Tyuiu.skirnevskyBR.Sprint6.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate() 
        {
            DataService ds = new DataService();
            int x = 3;

            double wait = 3.111;
            double res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }
    }
}
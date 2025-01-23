using Tyuiu.SungurovSV.Sprint4.Task1.V27.Lib;
namespace Tyuiu.SungurovSV.Sprint4.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5 };

            int res = ds.Calculate(array);
            int wait = 256;
            Assert.AreEqual(res, wait);
        }
    }
}
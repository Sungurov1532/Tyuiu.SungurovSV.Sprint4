using Tyuiu.SungurovSV.Sprint4.Task2.V25.Lib;
namespace Tyuiu.SungurovSV.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] massive_test = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2 };

            int res = ds.Calculate(massive_test);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
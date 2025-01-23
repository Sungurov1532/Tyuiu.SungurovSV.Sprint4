using Tyuiu.SungurovSV.Sprint4.Task0.V17.Lib;
namespace Tyuiu.SungurovSV.Sprint4.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int numsWaitArray = 32;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
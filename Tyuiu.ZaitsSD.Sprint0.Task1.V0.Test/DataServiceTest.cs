using System.ComponentModel.DataAnnotations;

using Tyuiu.ZaitsSD.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ZaitsSD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod] 
        public void CheckGetMessageValid()
        {
            var name = "Сережа";
            var res = DataService.GetMessage(name);

            Assert.AreEqual($"Привет..., Сережа", res);
        }
    }
}
 
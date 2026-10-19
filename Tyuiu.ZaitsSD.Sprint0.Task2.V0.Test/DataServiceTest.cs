using Tyuiu.ZaitsSD.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ZaitsSD.Sprint0.Task2.V0.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Сергей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Сергей", res);
        }
    }
}

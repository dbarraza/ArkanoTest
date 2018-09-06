using ComputerApp.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerApp.Test
{
    [TestClass]
    public class MemoryControllerTest
    {
        [TestMethod]
        public void GetMethod_Test()
        {
            //Arrange
            var memorySvc = new FakeMemorySvcImpl();
            var controller = new MemoryController(memorySvc);

            //Act
            var result = controller.Get();

            //Assert
            var expected = 2;
            Assert.AreEqual(expected,result.Capacity);
        }
    }
}

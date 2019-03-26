using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using Moq;
using NUnit.Framework;
using BusinessLayer;
using DataLayer.Interfaces;
using BusinessLayer.Interfaces;
using Common.Interfaces;
using Common.Models;

namespace Test.BusinessLayer
{
    [TestFixture]
    public class FrameWorkTest
    {
        private Mock<IDataService> dataService;
        private Mock<ILogService> logService;
        private Mock<IErrorService> errorService;

        [SetUp]
        public void SetUp()
        {
            dataService = new Mock<IDataService>();
            logService = new Mock<ILogService>();
            errorService = new Mock<IErrorService>();
        }
        [Test]
        public void Add_Item_ReturnItem()
        {
            //Arrange
            IItemActive item = new ItemActive();
            item.Name = "akármi";
            var testObject = new FrameWork(dataService.Object, logService.Object, errorService.Object);

            //Act
            testObject.AddItemActive(item);
            var result = testObject.GetItemByID(item.ID);

            //Assert
            Assert.That(result, Is.EqualTo(item));
        }

    }
}

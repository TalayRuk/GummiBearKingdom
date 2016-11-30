using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Controllers;
using GummiBearKingdom.Models;
using Xunit;

namespace GummiBearKingdom.Tests.ControllerTests
{
    public class ProductsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange 
            ProductsController controller = new ProductsController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}

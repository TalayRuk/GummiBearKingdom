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
        //To verify that the controller.index returns a valid MVC view
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

        //After Xunit is configured, test if the model contains the right type of data. This case we want to be sure we will get list of products
        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            ProductsController controller = new ProductsController();
            //need to generate ViewResult indexView
            ViewResult indexView = new ProductsController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;
            
            //Assert
            Assert.IsType<List<Product>>(result);
        }
    }
}

//***Note: Test doesn't require the database to have any entries in it. Thus, this test doesn't evaluate anything about how our app is interacting with the database

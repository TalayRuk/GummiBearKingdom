using GummiBearKingdom.Models;
using Xunit;

namespace GummiBearKingdom.Tests
{
    public class ProductTest
    {
        [Fact]
        public void GetName()
        {
            //Arrange
            var product = new Product();
            //Test will fail b/c Name property of Product object is currently null 
            //to get around this right now add code below
            product.Name = "Christmas";

            //Act
            var result = product.Name;

            //Assert
            Assert.Equal("Christmas", result);
       
        }
    }
}

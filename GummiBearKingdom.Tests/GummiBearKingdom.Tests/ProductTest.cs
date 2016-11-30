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

            //Act
            var result = product.Name;

            //Assert
            Assert.Equal("Christmas", result);
       
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCart_app.Model;

namespace ShoppingCart_Test
{
    [TestClass]
    public class Product
    {
        [TestMethod]
        public void TotalCostTest()
        {
            //Arrange
            ShoppingCart_app.Model.Product product = new ShoppingCart_app.Model.Product(1, "Mango", 150.50, 10.0f);
            double price = 150.50;
            float discountPercent = 10.0f;

            //Act
            double expectedTotalCost = price - (price * discountPercent / 100);

            //Assert
            Assert.AreEqual(expectedTotalCost, product.TotalCost);
        }
    }
}

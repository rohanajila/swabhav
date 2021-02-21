using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCart_app.Model;


namespace ShoppingCart_Test
{
    [TestClass]
    public class LineItemTest
    {
        [TestMethod]
        public void CalculateTotalCostTest()
        {
            //Arrange
            Product product = new Product(1, "Mango", 50.50, 10.0f);
            LineItem item = new LineItem(1, 5, product);
             int quantity = 5;
            double price = 50.50;
            float discount = 10.0f;

            //Act
            double priceAfterDiscont = price - (price * discount/100);
            double expectedPrice = priceAfterDiscont * quantity;

            //Assert
            Assert.AreEqual(expectedPrice, item.CalculateTotalCost());

        }

    }
    
}

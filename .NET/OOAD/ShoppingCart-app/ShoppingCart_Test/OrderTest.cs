using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCart_app.Model;

namespace ShoppingCart_Test
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            ShoppingCart_app.Model.Product product = new ShoppingCart_app.Model.Product(1, "Mango", 50.50, 10.0f);
            LineItem item = new LineItem(1, 5, product);
            LineItem item1 = new LineItem(1, 5, product);
            int expectedQuantity = 10;
            Order order = new Order(1, DateTime.Now);


            //Act
            order.AddItem(item);
            order.AddItem(item1);

            //Assert
            Assert.AreEqual(expectedQuantity, item.Quantity);
            
        }
        [TestMethod ]
        public void CheckoutCostTest()
        {
            //Arrange
            ShoppingCart_app.Model.Product product1 = new ShoppingCart_app.Model.Product(1, "Mango", 50.50, 10.0f);
            LineItem item2 = new LineItem(1, 5, product1);
            LineItem item3 = new LineItem(1, 5, product1);
            double testCheckoutCost = 454.50;
            Order order1 = new Order(1, DateTime.Now);

            //Act
            order1.AddItem(item2);
            order1.AddItem(item3);

            //Assert
            Assert.AreEqual(testCheckoutCost, order1.CheckoutCost());
        }
    }
}

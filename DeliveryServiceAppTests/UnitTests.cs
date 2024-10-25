using DeliveryServiceApp_WinForms;
using System.Globalization;

namespace DeliveryServiceAppTests
{
    public class UnitTests
    {
        [Fact]
        public void FilterOrders_ShouldReturnOrdersInSpecifiedTimeFrame()
        {
            // Arrange
            var orders = new List<Order>
            {
                new Order { Id = 1, District = "District1", DeliveryTime = DateTime.ParseExact("2023-10-23 12:10:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) },
                new Order { Id = 2, District = "District1", DeliveryTime = DateTime.ParseExact("2023-10-23 12:45:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) }
            };
            DateTime firstOrderDateTime = DateTime.ParseExact("2023-10-23 12:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            // Act
            var result = MainForm.FilterOrders(orders, "District1", firstOrderDateTime, 30, caseSensitive: true);

            // Assert
            Assert.Single(result); 
            Assert.Equal(1, result[0].Id);
        }

        [Fact]
        public void WriteOrders_ShouldCreateOutputFileWithCorrectData()
        {
            // Arrange
            var orders = new List<Order>
            {
                new Order { Id = 1, Weight = 2.5, District = "District1", DeliveryTime = DateTime.ParseExact("2023-10-23 12:10:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) }
            };
            string resultFilePath = "test_result.txt";

            // Act
            MainForm.WriteOrders(resultFilePath, orders);

            // Assert
            Assert.True(File.Exists(resultFilePath));
            var fileContent = File.ReadAllLines(resultFilePath);
            Assert.Contains("1;2,5;District1;2023-10-23 12:10:00", fileContent);

            File.Delete(resultFilePath);
        }

        [Fact]
        public void ReadOrders_ShouldParseOrdersCorrectly()
        {
            // Arrange
            string ordersFilePath = "test_orders.txt";
            File.WriteAllLines(ordersFilePath, new[]
            {
                "1;2,5;District1;2023-10-23 12:10:00",
                "2;1,0;District2;2023-10-23 13:20:00"
            });

            // Act
            var orders = MainForm.ReadOrders(ordersFilePath);

            // Assert
            Assert.Equal(2, orders.Count);
            Assert.Equal("District1", orders[0].District);
            Assert.Equal(1.0, orders[1].Weight);

            File.Delete(ordersFilePath);
        }
    }
}
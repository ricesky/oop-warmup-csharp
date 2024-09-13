using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warmup.HelloCalculator;

namespace Warmup.HelloCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            // Inisialisasi objek Calculator sebelum setiap test
            calculator = new Calculator();
        }

        [TestMethod]
        public void Tambah_DuaAngka_ReturnsHasilPenjumlahan()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double expected = 8;

            // Act
            double result = calculator.Tambah(a, b);

            // Assert
            Assert.AreEqual(expected, result, "Penjumlahan dari 5 + 3 seharusnya menghasilkan 8.");
        }

        [TestMethod]
        public void Kurang_DuaAngka_ReturnsHasilPengurangan()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double expected = 2;

            // Act
            double result = calculator.Kurang(a, b);

            // Assert
            Assert.AreEqual(expected, result, "Pengurangan dari 5 - 3 seharusnya menghasilkan 2.");
        }

        [TestMethod]
        public void Kali_DuaAngka_ReturnsHasilPerkalian()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double expected = 15;

            // Act
            double result = calculator.Kali(a, b);

            // Assert
            Assert.AreEqual(expected, result, "Perkalian dari 5 * 3 seharusnya menghasilkan 15.");
        }

        [TestMethod]
        public void Bagi_DuaAngka_ReturnsHasilPembagian()
        {
            // Arrange
            double a = 6;
            double b = 3;
            double expected = 2;

            // Act
            double result = calculator.Bagi(a, b);

            // Assert
            Assert.AreEqual(expected, result, "Pembagian dari 6 / 3 seharusnya menghasilkan 2.");
        }

        [TestMethod]
        public void Bagi_DenganNol_ReturnsNaN()
        {
            // Arrange
            double a = 6;
            double b = 0;

            // Act
            double result = calculator.Bagi(a, b);

            // Assert
            Assert.IsTrue(double.IsNaN(result), "Pembagian dengan nol harus mengembalikan NaN.");
        }
    }
}

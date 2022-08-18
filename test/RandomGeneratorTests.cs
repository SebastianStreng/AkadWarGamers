using Application;
using NUnit.Framework;
using System;

namespace test
{
    [TestFixture]
    public class RandomGeneratorTests
    {
        [Test]
        public void generateRandom_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            int min = 1;
            int max = 2;

            // Act
            var result = RandomGenerator.generateRandom(
                min,
                max);

            // Assert
            Assert.That(result < 3);
        }
    }
}
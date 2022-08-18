using Application;
using Core;
using NUnit.Framework;
using System;

namespace test
{
    [TestFixture]
    public class AttackTests
    {
        private King TestKing1 = new King("King Arthur", 1000, 10, 15, 3);
        private King TestKing2 = new King("King Ludwig", 1000, 10, 15, 3);

        [Test]
        public void attack_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            // Act
            Attack.attack(
                TestKing1,
                TestKing2);

            // Assert
            Assert.That(TestKing2.warriors == 700);
        }

        [Test]
        public void runOver_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var numberOfWarriorsKing1 = TestKing1.warriors;
            var numberOfWarriorsKing2 = TestKing2.warriors;

            // Act
            Attack.runOver(
                TestKing1,
                TestKing2);

            // Assert
            Assert.That(TestKing1.warriors > numberOfWarriorsKing1 && TestKing2.warriors < numberOfWarriorsKing2);
        }
    }
}
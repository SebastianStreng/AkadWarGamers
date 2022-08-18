using Application;
using Core;
using NUnit.Framework;
using System;

namespace test
{
    [TestFixture]
    public class SpecialAttackTests
    {
        [Test]
        public void startSpecialAttack_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            King TestKing1 = new King("King Arthur", 1000, 10, 15, 3);
            King TestKing2 = new King("King Ludwig", 1000, 10, 15, 3);

            // Act
            SpecialAttack.startSpecialAttack(
                TestKing1,
                TestKing2);

            // Assert
            Assert.That(SpecialAttack.checker == true);
        }
    }
}
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
            King king1 = null;
            King king2 = null;

            // Act
            SpecialAttack.startSpecialAttack(
                king1,
                king2);

            // Assert
            Assert.That(SpecialAttack.checker == false);
        }
    }
}
using Application;
using Core;
using NUnit.Framework;
using System;

namespace test
{
    [TestFixture]
    public class SelectorTests
    {
        //To Test this Method, "decision" in Selector must be hardcoded.
        [Test]
        public void SelectInteraction_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            King TestKing1 = new King("King Arthur", 1000, 10, 15, 3);
            King TestKing2 = new King("King Ludwig", 1000, 10, 15, 3);

            // Act
            Selector.SelectInteraction(
                TestKing1,
                TestKing2);

            // Assert
            Assert.That(Selector.checker == true);
        }
    }
}
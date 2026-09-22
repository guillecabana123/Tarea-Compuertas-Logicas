using NUnit.Framework;

namespace Ucu.Poo.Exercise
{
    public class NotGateTests
    {
        [Test]
        public void Evaluate_True_ReturnsFalse()
        {
            // Arrange
            NotGate not = new OrGate();
            not.AddInput(new Value(true));

            // Act
            bool actual = not.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_False_ReturnsTrue()
        {
            // Arrange
            NotGate not = new OrGate();
            not.AddInput(new Value(false));

            // Act
            bool actual = not.Evaluate();

            // Assert
            Assert.That(actual, Is.True);
        }      
    }
}
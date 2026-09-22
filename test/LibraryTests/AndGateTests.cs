using NUnit.Framework;

namespace Ucu.Poo.Exercise
{
    public class AndGateTests
    {
        [Test]
        public void Evaluate_FalseAndFalse_ReturnsFalse()
        {
            // Arrange
            AndGate and = new AndGate();
            and.AddInput(new Value(false));
            and.AddInput(new Value(false));

            // Act
            bool actual = and.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_FalseAndTrue_ReturnsFalse()
        {
            // Arrange
            AndGate and = new AndGate();
            and.AddInput(new Value(false));
            and.AddInput(new Value(true));

            // Act
            bool actual = and.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_TrueAndFalse_ReturnsFalse()
        {
            // Arrange
            AndGate and = new AndGate();
            and.AddInput(new Value(true));
            and.AddInput(new Value(false));

            // Act
            bool actual = and.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_TrueAndTrue_ReturnsTrue()
        {
            // Arrange
            AndGate and = new AndGate();
            and.AddInput(new Value(true));
            and.AddInput(new Value(true));

            // Act
            bool actual = and.Evaluate();

            // Assert
            Assert.That(actual, Is.True);
        }
    }
}
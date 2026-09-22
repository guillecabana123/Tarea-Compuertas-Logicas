using NUnit.Framework;

namespace Ucu.Poo.Exercise
{
    public class OrGateTests
    {
        [Test]
        public void Evaluate_FalseAndFalse_ReturnsFalse()
        {
            // Arrange
            OrGate or = new OrGate();
            or.AddInput(new Value(false));
            or.AddInput(new Value(false));

            // Act
            bool actual = or.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_FalseAndTrue_ReturnsTrue()
        {
            // Arrange
            OrGate or = new OrGate();
            or.AddInput(new Value(false));
            or.AddInput(new Value(true));

            // Act
            bool actual = or.Evaluate();

            // Assert
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Evaluate_TrueAndFalse_ReturnsTrue()
        {
            // Arrange
            OrGate or = new OrGate();
            or.AddInput(new Value(true));
            or.AddInput(new Value(false));

            // Act
            bool actual = or.Evaluate();

            // Assert
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Evaluate_TrueAndTrue_ReturnsTrue()
        {
            // Arrange
            OrGate or = new OrGate();
            or.AddInput(new Value(true));
            or.AddInput(new Value(true));

            // Act
            bool actual = or.Evaluate();

            // Assert
            Assert.That(actual, Is.True);
        }
    }
}
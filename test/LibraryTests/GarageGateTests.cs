using NUnit.Framework;

namespace Ucu.Poo.Exercise
{
    public class GarageGateTests
    {
        [Test]
        public void Evaluate_NonePressed_ReturnsFalse()
        {
            // Arrange
            GarageGate gate = new GarageGate(false, false, false);

            // Act
            bool actual = gate.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_OnlyAPressed_ReturnsFalse()
        {
            // Arrange
            GarageGate gate = new GarageGate(true, false, false);

            // Act
            bool actual = gate.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_OnlyBPressed_ReturnsFalse()
        {
            // Arrange
            GarageGate gate = new GarageGate(false, true, false);

            // Act
            bool actual = gate.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_AAndBPressed_ReturnsFalse()
        {
            // Arrange
            GarageGate gate = new GarageGate(true, true, false);

            // Act
            bool actual = gate.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_OnlyCPressed_ReturnsTrue()
        {
            // Arrange
            GarageGate gate = new GarageGate(false, false, true);

            // Act
            bool actual = gate.Evaluate();

            // Assert
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Evaluate_AAndCPressed_ReturnsFalse()
        {
            // Arrange
            GarageGate gate = new GarageGate(true, false, true);

            // Act
            bool actual = gate.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_BAndCPressed_ReturnsFalse()
        {
            // Arrange
            GarageGate gate = new GarageGate(false, true, true);

            // Act
            bool actual = gate.Evaluate();

            // Assert
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Evaluate_AllPressed_ReturnsTrue()
        {
            // Arrange
            GarageGate gate = new GarageGate(true, true, true);

            // Act
            bool actual = gate.Evaluate();

            // Assert
            Assert.That(actual, Is.True);
        }
    }
}
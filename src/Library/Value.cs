namespace Ucu.Poo.Exercise
{
    public class Value : ILogicComponent
    {
        private bool value;

        public Value(bool value)
        {
            this.value = value;
        }

        public bool Evaluate()
        {
            return this.value;
        }
    }
}
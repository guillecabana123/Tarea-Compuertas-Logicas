namespace Ucu.Poo.Exercise
{
    public class AndGate : Gate
    {
        public override bool Evaluate()
        {
            bool result = true;
            foreach (ILogicComponent input in this.Inputs)
            {
                result = result && input.Evaluate();
            }

            return result;
        }
    }
}
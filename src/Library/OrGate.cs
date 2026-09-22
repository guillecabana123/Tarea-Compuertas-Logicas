namespace Ucu.Poo.Exercise
{
    public class OrGate : Gate
    {
        public override bool Evaluate()
        {
            bool result = false;
            foreach (ILogicComponent input in this.Inputs)
            {
                result = result || input.Evaluate();
            }

            return result;
        }
    }
}
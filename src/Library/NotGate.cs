namespace Ucu.Poo.Exercise
{
    public class NotGate : Gate
    {
        public override void AddInput(ILogicComponent input)
        {
            if (this.Inputs.Count < 1)
            {
                base.AddInput(input);
            }
        }

        public override bool Evaluate()
        {
            return !this.Inputs[0].Evaluate();
        }
    }
}
using System.Collections.Generic;

namespace Ucu.Poo.Exercise
{
    public abstract class Gate : ILogicComponent
    {
        private List<ILogicComponent> inputs = new List<ILogicComponent>();

        public void AddInput(ILogicComponent input)
        {
            this.inputs.Add(input);
        }

        public List<ILogicComponent> Inputs
        {
            get { return this.inputs; }
        }

        public abstract bool Evaluate();
    }
}
namespace Ucu.Poo.Exercise
{
    public class GarageGate
    {
        private ILogicComponent a;
        private ILogicComponent b;
        private ILogicComponent c;

        public GarageGate(bool a, bool b, bool c)
        {
            this.a = new Value(a);
            this.b = new Value(b);
            this.c = new Value(c);
        }

        public bool Evaluate()
        {
            AndGate andAB = new AndGate();
            andAB.AddInput(this.a);
            andAB.AddInput(this.b);

            NotGate notA = new NotGate();
            notA.AddInput(this.a);

            NotGate notB = new NotGate();
            notB.AddInput(this.b);

            AndGate andNotAB = new AndGate();
            andNotAB.AddInput(notA);
            andNotAB.AddInput(notB);

            OrGate or = new OrGate();
            or.AddInput(andAB);
            or.AddInput(andNotAB);

            AndGate finalAnd = new AndGate();
            finalAnd.AddInput(or);
            finalAnd.AddInput(this.c);

            return finalAnd.Evaluate();
        }
    }
}
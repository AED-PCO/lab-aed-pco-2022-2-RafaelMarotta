namespace Calculadora_Polonesa.handlers
{
    public class OperatorHandler : ITokenHandler
    {
        public void HandleToken(IPolishConversor calculator, string token)
        {
            MyStack<string> opStack = calculator.OperatorStack;

            if (!opStack.IsEmpty())
            {
                string nextOp = opStack.Peek();
                int opWeight = OperatorsWeight.GetWeight(token);
                int nextOpWeight = -1;
                if (IsToken(nextOp))
                {
                    nextOpWeight = OperatorsWeight.GetWeight(nextOp);
                }

                if (nextOpWeight >= opWeight)
                {
                    calculator.RpnQueue.Push(opStack.Pull());
                }
            }
            opStack.Push(token);
        }

        public bool IsToken(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }
    }
}

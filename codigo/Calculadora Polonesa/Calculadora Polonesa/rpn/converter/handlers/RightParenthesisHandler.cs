namespace Calculadora_Polonesa.handlers
{
    public class RightParenthesisHandler : ITokenHandler
    {
        public void HandleToken(IPolishConversor calculator, string token)
        {
            MyStack<string> opStack = calculator.OperatorStack;
            MyQueue<string> output = calculator.RpnQueue;

            string op = opStack.Pull();
      
            while (op != "(") {
                output.Push(op);
                op = opStack.Pull();
            }
        }

        public bool IsToken(string token)
        {
            return token == ")";
        }
    }
}

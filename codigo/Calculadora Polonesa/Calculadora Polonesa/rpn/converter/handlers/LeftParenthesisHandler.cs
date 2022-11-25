namespace Calculadora_Polonesa.handlers
{
    public class LeftParenthesisHandler : ITokenHandler
    {
        public void HandleToken(IPolishConversor calculator, string token)
        {
            calculator.OperatorStack.Push(token);
        }

        public bool IsToken(string token)
        {
            return token == "(";
        }
    }
}

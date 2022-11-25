namespace Calculadora_Polonesa.handlers
{
    public class NumberHandler : ITokenHandler
    {
        public void HandleToken(IPolishConversor calculator, string token)
        {
            calculator.RpnQueue.Push(token);
        }

        public bool IsToken(string token)
        {
            return int.TryParse(token,out _);
        }
    }
}

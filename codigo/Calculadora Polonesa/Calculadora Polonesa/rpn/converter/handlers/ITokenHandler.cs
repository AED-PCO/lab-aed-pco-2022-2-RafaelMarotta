namespace Calculadora_Polonesa
{
    public interface ITokenHandler
    {
        bool IsToken(string token);
        void HandleToken(IPolishConversor calculator, string token);
    }
}

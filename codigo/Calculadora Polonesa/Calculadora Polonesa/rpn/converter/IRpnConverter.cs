namespace Calculadora_Polonesa
{
    public interface IPolishConversor
    {
        MyStack<string> OperatorStack { get; }
        MyQueue<string> RpnQueue { get; }
    }
}

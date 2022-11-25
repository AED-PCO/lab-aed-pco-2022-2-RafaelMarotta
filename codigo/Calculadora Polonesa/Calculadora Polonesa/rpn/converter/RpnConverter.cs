using System.Collections.Generic;

namespace Calculadora_Polonesa
{
    public class PolishConversor : IPolishConversor
    {
        public MyStack<string> OperatorStack { get; }

        public MyQueue<string> RpnQueue { get; }

        private List<ITokenHandler> Handlers;

        public PolishConversor()
        {
            OperatorStack = new MyStack<string>();
            RpnQueue = new MyQueue<string>();
            Handlers = new List<ITokenHandler>();
        }

        public void AddHandler(ITokenHandler handler)
        {
            Handlers.Add(handler);
        }

        public MyQueue<string> GetReversePolishNotation(MyQueue<string> tokens)
        {
            while (!tokens.IsEmpty())
            {
                string token = tokens.Pull();
                ITokenHandler handler = Handlers.Find(e => e.IsToken(token));
                handler.HandleToken(this, token);
            }

            while(!OperatorStack.IsEmpty())
            {
                RpnQueue.Push(OperatorStack.Pull());
            }

            return RpnQueue;
        }

    }
}

namespace Calculadora_Polonesa.rpn.calculator
{
    public class RpnCalculator
    {
        public static double Calculate(MyQueue<string> rpn)
        {
            MyStack<double> numbers = new MyStack<double>();

            while (!rpn.IsEmpty())
            {
                string token = rpn.Pull();
                if (IsOperation(token))
                {
                    double n1 = numbers.Pull();
                    double n2 = numbers.Pull();
                    numbers.Push(Calculate(token, n1, n2));
                }
                else
                {
                    numbers.Push(int.Parse(token));
                }
            }
            return numbers.Pull();
        }

        private static bool IsOperation(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        private static double Calculate(string op, double n1, double n2)
        {
            if (op == "+")
            {
                return n1 + n2;
            }
            if (op == "-")
            {
                return n1 - n2;
            }
            if (op == "*")
            {
                return n1 * n2;
            }
            return n2/n1;
        }
    }
}

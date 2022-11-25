using System.Collections.Generic;

namespace Calculadora_Polonesa
{
    internal class OperatorsWeight
    {
        private static Dictionary<string, int> Operators = new Dictionary<string, int>();
        public static void Init()
        {
            Operators.Add("+", 1);
            Operators.Add("-", 1);
            Operators.Add("*", 2);
            Operators.Add("/", 2);
        }

        public static int GetWeight(string op)
        {
            return Operators[op];
        }
       
    }
}

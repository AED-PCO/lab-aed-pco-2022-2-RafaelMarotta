using Calculadora_Polonesa.handlers;
using Calculadora_Polonesa.rpn.calculator;
using System;

namespace Calculadora_Polonesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue<string> input = ReadExp();
            MyQueue<string> rpn = RpnConverter(input.Clone());
            double result = RpnCalculator.Calculate(rpn.Clone());
            PrintResults(input, rpn, result);
            Console.ReadKey();
        }

        static MyQueue<string> ReadExp()
        {
            MyQueue<string> inputQueue = new MyQueue<string>();
            string input = Console.ReadLine().Replace(" ", "");
            string lastNumber = "";
            foreach (char c in input.Trim().ToCharArray())
            {
                if (IsNumber(c.ToString()))
                {
                    lastNumber += c.ToString();
                } 
                else
                {
                    if (IsNumber(lastNumber))
                    {
                        inputQueue.Push(lastNumber);
                        lastNumber = "";
                    }
                    inputQueue.Push(c.ToString());
                }
            }
            if (IsNumber(lastNumber))
            {
                inputQueue.Push(lastNumber);
            }

            return inputQueue;
        }

        static bool IsNumber(string c)
        {
            return int.TryParse(c, out _);
        }


        static void PrintResults(MyQueue<string> input, MyQueue<string> rpn, double result)
        {
            Console.Clear();
            Console.Write("Infix Notation: ");
            input.Print();
            Console.Write("\nRPN: ");
            rpn.Print();
            Console.WriteLine("\nResult: " + result);
        }

        static MyQueue<string> RpnConverter(MyQueue<string> queue)
        {
            OperatorsWeight.Init();
            PolishConversor conversor = new PolishConversor();
            conversor.AddHandler(new OperatorHandler());
            conversor.AddHandler(new LeftParenthesisHandler());
            conversor.AddHandler(new RightParenthesisHandler());
            conversor.AddHandler(new NumberHandler());
            return conversor.GetReversePolishNotation(queue);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KR
{

    public class Fraction
    {
        static private Fraction _instance;
        public static Fraction Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Fraction();
                return _instance;
            }
        }
        private Fraction()
        {
        }

        private static readonly string[] operators = ["+", "-", "*", "/"];

        public float Calculate(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("Вхідний рядок не може бути порожнім");

            var tokens = expression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<float>();

            foreach (var token in tokens)
            {
                if (float.TryParse(token, out var number))
                    stack.Push(number);
                else if (operators.Contains(token))
                {
                    if (stack.Count < 2)
                        throw new InvalidOperationException("Недостатньо операндів");
                    var b = stack.Pop();
                    var a = stack.Pop();
                    var result = token switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => b == 0 ? throw new DivideByZeroException() : a / b,
                        _ => throw new InvalidOperationException($"Невідомий оператор: {token}")
                    };

                    stack.Push(result);
                }
                else
                    throw new InvalidOperationException($"Некоректний значення: {token}");
            }

            if (stack.Count != 1)
                throw new InvalidOperationException("Некоректний вираз");

            return stack.Pop();
        }


        public string GetConvertToPolishInverseEntry(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                throw new ArgumentException("Вхідний рядок не може бути порожнім");

            var output = new StringBuilder();
            var stack = new Stack<string>();
            var precedence = new Dictionary<string, int> { ["+"] = 1, ["-"] = 1, ["*"] = 2, ["/"] = 2 };
            str = str.Replace(",", ".");
            foreach (var token in str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (float.TryParse(token, out _))
                    output.Append($"{token} ");
                else if (token == "(")
                    stack.Push(token);
                else if (token == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                        output.Append($"{stack.Pop()} ");

                    if (stack.Count == 0 || stack.Peek() != "(")
                        throw new ArgumentException("Помилка! Немає пари до дужки");

                    stack.Pop();
                }
                else if (operators.Contains(token))
                {
                    while (stack.Count > 0 && stack.Peek() != "(" && precedence[stack.Peek()] >= precedence[token])
                        output.Append($"{stack.Pop()} ");

                    stack.Push(token);
                }
                else
                    throw new ArgumentException($"Некоректний значення: {token}");
            }

            while (stack.Count > 0)
            {
                if (stack.Peek() == "(")
                    throw new ArgumentException("Помилка! Немає пари до дужки");

                output.Append($"{stack.Pop()} ");
            }
            return output.ToString().Trim();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KR
{
    public class Fraction
    {
        static private Fraction _instance;
        public static Fraction Instance
        {
            get
            {
                _instance ??= new Fraction();
                return _instance;
            }
        }
        private Fraction() { }

        private readonly string[] operators = ["+", "-", "*", "/", "^", "sqrt"];
        public float Calculate(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("Вхідний рядок не може бути порожнім ");

            string[] tokens = expression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Stack<float> stack = new Stack<float>();
            foreach (var token in tokens)
            {
                if (float.TryParse(token, out var number))
                    stack.Push(number);
                else if (operators.Contains(token))
                {
                    if (token == "sqrt")
                    {
                        if (stack.Count < 1)
                            throw new InvalidOperationException("Недостатньо операндів для sqrt");
                        float a = stack.Pop();
                        if (a < 0)
                            throw new InvalidOperationException("Квадратний корінь з від'ємного числа неможливий");
                        stack.Push((float)Math.Round(Math.Sqrt(a)));
                    }
                    else
                    {
                        if (stack.Count < 2)
                            throw new InvalidOperationException("Недостатньо операндів");
                        float b = stack.Pop();
                        float a = stack.Pop();
                        float result = token switch
                        {
                            "+" => a + b,
                            "-" => a - b,
                            "*" => a * b,
                            "/" => b == 0 ? throw new DivideByZeroException("Ділення на нуль") : a / b,
                            "^" => b < 0 ? (a == 0 ? throw new DivideByZeroException("Ділення на нуль при від'ємному степені") : (float)(1.0 / Math.Pow(a, -b))) : (float)Math.Pow(a, b),
                            _ => throw new InvalidOperationException($"Невідомий оператор: {token}")
                        };
                        stack.Push(result);
                    }
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

            StringBuilder output = new();
            Stack<string> stack = new();
            Dictionary<string, int> precedence = new Dictionary<string, int>
            {
                ["+"] = 1,
                ["-"] = 1,
                ["*"] = 2,
                ["/"] = 2,
                ["^"] = 3,
                ["sqrt"] = 4
            };
            Regex TokenPattern = new(@"-?\d+(\.?\d+)?|[\+\-\*/\(\)\^]|sqrt");
            MatchCollection matches = TokenPattern.Matches(str);
            foreach (Match match in matches)
            {
                string token = match.Value;
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
                    while (stack.Count > 0 && stack.Peek() != "(" && (token == "sqrt" ? precedence[stack.Peek()] > precedence[token] : precedence[stack.Peek()] >= precedence[token]))
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
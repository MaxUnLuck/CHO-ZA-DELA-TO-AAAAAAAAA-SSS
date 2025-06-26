using System;

namespace MathExpressionCalculator
{
    public static class Calculator
    {
        public static double Calculate(double a, double b)
        {
            // Проверка допустимости входных параметров
            if (b == 0) throw new ArgumentException("b не может быть равно 0");
            if (a <= 0 || b <= 0) throw new ArgumentException("a и b должны быть положительными");
            // Вычисление числителя
            double V1 = Math.Pow(a, 10) / Math.Pow(Math.Pow(b, 5), 1.0 / 3);
            double V2 = Math.Log(V1, 3);
            double V3 = Math.Pow(V2, -0.2) + 2 * a * Math.Pow(b, 3);
            // Вычисление знаменателя
            double denominatorPart1 = 3 * Math.Pow(b, 1.0 / 3) + Math.Atan(2 * a);
            double denominatorPart2 = 3 * Math.Exp(Math.Sqrt(a * b));
            double denominator = denominatorPart1 / denominatorPart2;
            return V3 / denominator;
        }
    }
}
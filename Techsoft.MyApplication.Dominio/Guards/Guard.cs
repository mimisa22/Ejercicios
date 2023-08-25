using System;

namespace MyApplication.Guards
{
    internal static class Guard
    {
        public static string Length(string value, string argument, int min, int max)
        {
            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentException($"El argumento {argument}: {value} no es válido");
            }
            return value;
        }

        internal static int MinValue(int value, string argument, int min)
        {
            return value < min ? throw new ArgumentException($"El argumento {argument}: {value} no es válido") : value;
        }

        internal static string IsNumeric(this string value)
        {
            var result = long.TryParse(value, out long number) ? value : throw new ArgumentException($"El valor {value} debería ser numérico");

            return result;
        }

    }
}

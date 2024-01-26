using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimHandler
{
    public static class StringExtensions
    {
        public static string PrintIfNotEmpty(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            return $" // {value}";
        }

        public static string PrintAsCurrency(this string value)
        {
            decimal.TryParse(value, out decimal result);
            return result.ToString("C2");
        }
    }
}

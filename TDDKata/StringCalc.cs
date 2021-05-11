// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDKata
{
    internal class StringCalc
    {
        internal int Sum(string numbers)
        {
            var separatingStrings = new List<string>(){ ",", "\n"};

            if (numbers.StartsWith("//"))
            {
                separatingStrings.Add(";");
                separatingStrings.Add(":");
            }

            string[] array = numbers.Split(separatingStrings.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            var digits = GetListOfDigits(array);

            return digits.Sum();
        }

        private IEnumerable<int> GetListOfDigits(string[] array)
        {
            var listData = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                var element = array[i];

                if (int.TryParse(element, out var digit))
                {
                    if (digit < 0)
                    {
                        return new List<int>() { -1 };
                    }
                    else
                    {
                        listData.Add(digit);
                    }
                }
                else if (string.IsNullOrWhiteSpace(element))
                {
                    listData.Add(0);
                }
            }

            return listData;
        }
    }
}
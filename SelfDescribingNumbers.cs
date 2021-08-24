namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;

    public static class SelfDescribingNumbers
    {
        static void Main()
        {
            Console.WriteLine(IsSelfDescribingNumber("2020")); // Expected answer true
        }
        private static bool IsSelfDescribingNumber(string line)
        {
            Dictionary<int, int> digitToFrequencyDict = new Dictionary<int, int>();
            // Populate dictionary
            foreach (var entry in line)
            {
                int digit = entry - '0'; // - '0' allows numerical char to be treated as if it were an int.
                if (digitToFrequencyDict.ContainsKey(digit))
                {
                    digitToFrequencyDict[digit]++;
                }
                else
                {
                    digitToFrequencyDict[digit] = 1;
                }
            }
            // Check if a self-describing number
            for (int i = 0; i < line.Length; i++)
            {
                int valueOfIntAtPosition = line[i] - '0';
                int freqOfIVal = digitToFrequencyDict.ContainsKey(i) ? digitToFrequencyDict[i] : 0;
                if (valueOfIntAtPosition != freqOfIVal)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System;

namespace WriteStringFromMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your input here.");
            string strInput = Console.ReadLine().Trim();
            int midIndex = (strInput.Length % 2) == 0 ? (strInput.Length / 2) - 1 : (strInput.Length / 2);
            string tempString = string.Empty;
            for (int index = midIndex; index < strInput.Length; index++)
            {
                tempString += strInput[index];
                Console.WriteLine(tempString);
            }
            for (int index = 0; index < midIndex; index++)
            {
                tempString += strInput[index];
                Console.WriteLine(tempString);
            }
            tempString = null;
            strInput = null;
        }
    }
}

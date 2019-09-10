using System;
using System.Collections.Generic;
using System.Text;

namespace DB_ApplicantChallenge
{
    class Pyramid
    {
        private const string SPACE = " ";
        private const int RIGHT_CHILD = 1;
        private List<int> maxSumPath;
        private string[] fileContent;
        private bool even;

        public Pyramid(string[] _fileContent)
        {
            fileContent = _fileContent;
            maxSumPath = new List<int>();
            even = false;
        }                      

        public bool AddToMaxSumPath(int lineNumber, int numberIndex)
        {
            if (lineNumber>=fileContent.Length)
            {
                return false;
            }
            string[] numbers = ReadLine(lineNumber);
            int currentNumber = Int32.Parse(numbers[numberIndex]);
            LargestNumberHelper largestNumberHelper = getLargestNumber(currentNumber, numberIndex, numbers);
            maxSumPath.Add(largestNumberHelper.LargestNumber);
            lineNumber++;
            even = !even;
            AddToMaxSumPath(lineNumber, largestNumberHelper.Index);
            return true;
        }        

        private string[] ReadLine(int lineNumber)
        {
            return fileContent[lineNumber].Split(SPACE);
        }

        private LargestNumberHelper getLargestNumber(int currentNumber, int index, string[] numbers)
        {
            int largestNumber = -1;
            // Check left child
            if (isEven(currentNumber) == even && currentNumber > largestNumber)
            {
                largestNumber = currentNumber;
            }
            // Check right child
            if (index + RIGHT_CHILD < numbers.Length)
            {
                currentNumber = Int32.Parse(numbers[index + RIGHT_CHILD]);
                if (isEven(currentNumber) == even && currentNumber > largestNumber)
                {
                    largestNumber = currentNumber;
                    index++;
                }
            }
            return new LargestNumberHelper(largestNumber, index);
        }

        private bool isEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public void PrintOutput()
        {
            Console.WriteLine("Input: ");
            foreach (string line in fileContent)
            {
                Console.WriteLine($"{line}");
            }
            Console.WriteLine("\nOutput: ");
            int sum = 0;
            string path = "";
            foreach (int node in maxSumPath)
            {
                sum += node;
                path += $"{node}, ";
            }
            Console.WriteLine($"Max sum: {sum}");
            Console.WriteLine($"Path: {path}");
            Console.WriteLine("\nPress any key to exit...\n");
            Console.ReadKey();
        }
    }
}

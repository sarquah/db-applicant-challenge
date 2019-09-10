using System;
using System.Collections.Generic;

namespace DB_ApplicantChallenge
{
    class Pyramid : IPyramid
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
            LargestNumberHelper largestNumberHelper = GetLargestNumber(currentNumber, numberIndex, numbers);
            maxSumPath.Add(largestNumberHelper.LargestNumber);
            lineNumber++;
            even = !even;
            AddToMaxSumPath(lineNumber, largestNumberHelper.Index);
            return true;
        }        

        public string[] ReadLine(int lineNumber)
        {
            return fileContent[lineNumber].Split(SPACE);
        }

        public LargestNumberHelper GetLargestNumber(int currentNumber, int index, string[] numbers)
        {
            int largestNumber = -1;
            // Check left child
            if (IsEven(currentNumber) == even && currentNumber > largestNumber)
            {
                largestNumber = currentNumber;
            }
            // Check right child
            if (index + RIGHT_CHILD < numbers.Length)
            {
                currentNumber = Int32.Parse(numbers[index + RIGHT_CHILD]);
                if (IsEven(currentNumber) == even && currentNumber > largestNumber)
                {
                    largestNumber = currentNumber;
                    index++;
                }
            }
            return new LargestNumberHelper(largestNumber, index);
        }

        public bool IsEven(int number)
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

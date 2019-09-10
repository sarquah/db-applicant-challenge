using System;
using System.Collections.Generic;
using System.Text;

namespace DB_ApplicantChallenge
{
    class Pyramid
    {
        private const string SPACE = " ";
        private List<int> path;
        private string[] fileContent;
        private bool even;

        public Pyramid()
        {
            path = new List<int>();
            even = false;
        }
        public void ReadFile(string path)
        {
            fileContent = System.IO.File.ReadAllLines(path);            
            AddNode(0, 0);
            Console.WriteLine("Press any key to exit.");
        }

        private string[] ReadLine(int lineNumber)
        {
            return fileContent[lineNumber].Split(SPACE);
        }

        private bool AddNode(int lineNumber, int numberIndex)
        {
            if (lineNumber>=fileContent.Length)
            {
                return false;
            }
            string[] numbers = ReadLine(lineNumber);
            int largestNumber = -1;
            int index = 0;
            int currentNumber = Int32.Parse(numbers[numberIndex]);                
            if (isEven(currentNumber) == even && currentNumber > largestNumber)
            {
                largestNumber = currentNumber;
                index = numberIndex;
            }
            if (numberIndex + 1 < numbers.Length)
            {
                currentNumber = Int32.Parse(numbers[numberIndex + 1]);
                if (isEven(currentNumber) == even && currentNumber > largestNumber)
                {
                    largestNumber = currentNumber;
                    index = numberIndex+1;
                }
            }
            numberIndex++;
            path.Add(largestNumber);
            lineNumber++;
            even = !even;
            AddNode(lineNumber, index);
            return true;
        }

        private bool isEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }
    }
}

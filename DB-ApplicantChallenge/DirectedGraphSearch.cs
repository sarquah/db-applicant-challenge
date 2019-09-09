using System;
using System.Collections.Generic;
using System.Text;

namespace DB_ApplicantChallenge
{
    class DirectedGraphSearch
    {
        private const string SPACE = " ";

        public DirectedGraphSearch()
        {

        }
        public List<int> maxSum()
        {
            return null;
        }
        public List<Node> readFile(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            for (int lineIndex = 0; lineIndex < lines.Length; lineIndex++)
            {
                string[] numbers = lines[lineIndex].Split(SPACE);
                for (int numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
                {
                    int number = Int32.Parse(numbers[numberIndex]);
                    Node node = new Node(number);
                    if ((lineIndex + 1) < lines.Length)
                    {
                        // Read next line
                        string[] nextLineNumbers = lines[lineIndex + 1].Split(SPACE);
                        node.Left = new Node(Int32.Parse(nextLineNumbers[numberIndex]));
                        node.Right = new Node(Int32.Parse(nextLineNumbers[numberIndex + 1]));                        
                    }
                }
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            return null;
        }
        public int move(bool odd)
        {
            if (odd)
            {
                return -1;
            }
            else
            {
                return -1;
            }
        }
    }
}

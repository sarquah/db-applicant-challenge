using System;
using System.Collections.Generic;
using System.Text;

namespace DB_ApplicantChallenge
{
    class Pyramid
    {
        private const string SPACE = " ";
        private Node root;
        private List<Node> unorderedInput;
        private string[] fileContent;

        public Pyramid()
        {
            root = null;
            unorderedInput = new List<Node>();
        }
        public void ReadFile(string path)
        {
            fileContent = System.IO.File.ReadAllLines(path);
            string[] numbers = ReadLine(0);
            AddNodes(numbers);
            Console.WriteLine("Press any key to exit.");
        }

        private string[] ReadLine(int lineNumber)
        {
            return fileContent[lineNumber].Split(SPACE);
        }

        private void AddNodes(string[] numbers)
        { 
            int number = -1;
            number = Int32.Parse(numbers[0]);
            Node node = new Node(number);
            string[] nextLine = null;
            for (int lineNumber = 1; lineNumber < numbers.Length; lineNumber++)
            {
                nextLine = ReadLine(lineNumber);
                node = AddChildren(nextLine, 0, lineNumber, node);
                if (root==null)
                {
                    root = node;
                }
            }
        }

        private Node AddChildren(string[] nextLine, int numberIndex, int lineNumber, Node parent)
        {
            int number = Int32.Parse(nextLine[numberIndex]);
            Node child1 = new Node(number);
            parent.Children.Add(child1);

            number = Int32.Parse(nextLine[numberIndex + 1]);
            Node child2 = new Node(number);
            parent.Children.Add(child2);

            return parent;
        }
    }
}

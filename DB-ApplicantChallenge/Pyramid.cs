using System;
using System.Collections.Generic;
using System.Text;

namespace DB_ApplicantChallenge
{
    class Pyramid
    {
        private const string SPACE = " ";
        private Node root;
        private Node previousNode;

        public Pyramid()
        {
            root = null;
        }
        public List<Node> ReadFile(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            for (int currentLineNumber = 0; currentLineNumber < lines.Length; currentLineNumber++)
            {
                string[] nextLine = null;
                if ((currentLineNumber + 1) < lines.Length)
                {
                    nextLine = lines[currentLineNumber + 1].Split(SPACE);
                }                
                ReadLine(lines[currentLineNumber], nextLine, currentLineNumber);
            }
            Console.WriteLine("Press any key to exit.");
            return null;
        }

        private void ReadLine(string currentLine, string[] nextLine, int currentLineNumber)
        {
            string[] numbers = currentLine.Split(SPACE);
            int leftValue = -1;
            int rightValue = -1;
            int number = -1;
            for (int numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
            {
                number = Int32.Parse(numbers[numberIndex]);
                if (nextLine != null)
                {
                    leftValue = Int32.Parse(nextLine[numberIndex]);
                    rightValue = Int32.Parse(nextLine[numberIndex + 1]);
                }
                Node node = CreateNode(number, nextLine, leftValue, rightValue, currentLineNumber);
                InsertNode(node);
            }
        }

        private void InsertNode(Node node)
        {
            if (root == null)
            {
                root = node;
                previousNode = node;
            }
            else
            {
                if (root.Left.Value == node.Value)
                {
                    root.Left = node;
                }
                else if (root.Right.Value == node.Value)
                {
                    root.Right = node;
                }
            }
        }

        private Node CreateNode(int number, string[] nextLine, int leftValue, int rightValue, int currentLineNumber)
        {            
            Node node = new Node(number);
            if (leftValue > -1)
            {              
                node.Left = new Node(leftValue);
                node.Right = new Node(rightValue);
            }
            //if (root == null)
            //{
            //    root = node;
            //}
            //else
            //{
            //    AddChild(node, currentLineNumber);
            //}
            return node;
        }

        private void AddChild(Node node, int currentLineNumber)
        {
            Node currentNode = root;
            for (int depth=0; depth < currentLineNumber;depth++)
            {                
                if (currentLineNumber == 1)
                {
                    if (root.Left.Value == node.Value)
                    {
                        root.Left = node;
                    }
                    else if (root.Right.Value == node.Value)
                    {
                        root.Right = node;
                    }
                }
                else
                {

                }
            }
        }
    }
}

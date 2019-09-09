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
        public List<Node> readFile()
        {
            List<Node> directGraph = new List<Node>();
            string[] lines = System.IO.File.ReadAllLines(
                @"C:\Users\g3n3s\source\repos\DB-ApplicantChallenge\DB-ApplicantChallenge\SampleInput.txt");
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
                        Node child1 = new Node(Int32.Parse(nextLineNumbers[numberIndex]));
                        node.Children.Add(child1);
                        Node child2 = new Node(Int32.Parse(nextLineNumbers[numberIndex + 1]));
                        node.Children.Add(child2);
                        //Console.Write($"\t {node.Value} \tChildren: {node.Children[0].Value}, {node.Children[1].Value} -");
                    }
                    directGraph.Add(node);
                }
                //Console.WriteLine();
            }
            foreach(var node in directGraph)
            {
                string children="";
                foreach(var child in node.Children)
                {
                    children += child.Value+",";
                }
                Console.WriteLine($"{node.Value} - Children: {children}");
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

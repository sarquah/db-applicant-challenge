using System;
using System.Collections.Generic;
using System.Text;

namespace DB_ApplicantChallenge
{
    class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int _value, Node _left, Node _right)
        {
            Value = _value;
            Left = _left;
            Right = _right;
        }
        public Node(int _value)
        {
            Value = _value;
        }
    }
}

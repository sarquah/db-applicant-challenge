using System;
using System.Collections.Generic;
using System.Text;

namespace DB_ApplicantChallenge
{
    class Node
    {
        public int Value { get; set; }
        public List<Node> Children { get; set; }

        public Node(int _value)
        {
            Value = _value;
            Children = new List<Node>();
        }
    }
}

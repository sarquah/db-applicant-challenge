using System;

namespace DB_ApplicantChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectedGraphSearch dgs = new DirectedGraphSearch();
            dgs.readFile();
        }
    }
}

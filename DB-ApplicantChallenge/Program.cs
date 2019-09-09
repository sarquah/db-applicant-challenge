using System;

namespace DB_ApplicantChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectedGraphSearch dgs = new DirectedGraphSearch();
            dgs.readFile(@"C:\Users\g3n3s\source\repos\DB-ApplicantChallenge\DB-ApplicantChallenge\SampleInput.txt");
        }
    }
}

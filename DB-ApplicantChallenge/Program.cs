using System;

namespace DB_ApplicantChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid pyramid = new Pyramid();
            pyramid.ReadFile(@"C:\Users\g3n3s\source\repos\DB-ApplicantChallenge\DB-ApplicantChallenge\SampleInput.txt");
        }
    }
}

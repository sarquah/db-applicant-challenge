using System;

namespace DB_ApplicantChallenge
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] fileContent = ReadFile(@"C:\Users\g3n3s\source\repos\DB-ApplicantChallenge\DB-ApplicantChallenge\SampleInput.txt");
            Pyramid pyramid = new Pyramid(fileContent);
            pyramid.AddToMaxSumPath(0, 0);
            pyramid.PrintOutput();
            
            fileContent = ReadFile(@"C:\Users\g3n3s\source\repos\DB-ApplicantChallenge\DB-ApplicantChallenge\QuestionInput.txt");
            pyramid = new Pyramid(fileContent);
            pyramid.AddToMaxSumPath(0, 0);
            pyramid.PrintOutput();
        }

        static string[] ReadFile(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }
    }
}

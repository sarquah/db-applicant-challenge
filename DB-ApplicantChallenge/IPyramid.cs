namespace DB_ApplicantChallenge
{
    public interface IPyramid
    {
        bool AddToMaxSumPath(int lineNumber, int numberIndex);
        string[] ReadLine(int lineNumber);
        LargestNumberHelper GetLargestNumber(int currentNumber, int index, string[] numbers);
        bool IsEven(int number);
        void PrintOutput();
    }
}
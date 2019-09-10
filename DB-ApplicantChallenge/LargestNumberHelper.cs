using System;
using System.Collections.Generic;
using System.Text;

namespace DB_ApplicantChallenge
{
    class LargestNumberHelper
    {
        public int LargestNumber { get; set; }
        public int Index { get; set; }

        public LargestNumberHelper(int _LargestNumber, int _Index)
        {
            LargestNumber = _LargestNumber;
            Index = _Index;
        }
    }
}

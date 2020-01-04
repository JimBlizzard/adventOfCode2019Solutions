using System;

namespace day04
{
    class Program
    {

        // int[] inputStart; // should represent the input as an array (i.e.: 111 -> int[]{1,1,1})

        // [X] 1. in range
        // range => 123257-647015
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // start is lower end of range
            // end is upper end of range
            int start = 123257;
            int end = 647015;

            Console.WriteLine("Creating PWGen");
            var pwg = new PWGenerator();
            var validPwdCount = pwg.countAllValidPwd(start, end);

            Console.WriteLine("Valid password count: {0} ", validPwdCount);
        }
    }

    class PWGenerator
    {
        private int validPwdCount = 0;
        private char[] potentialPwd;

        public int countAllValidPwd(int start, int end)
        {
            for (; start <= end; start++) // we'll always be in range :) 
            {
                potentialPwd = start.ToString().ToCharArray();
                if (allGreaterOrEqual() && atLeastOneAdjacent())
                {
                    // valid password!
                    validPwdCount++;
                }
            }

            return validPwdCount;
        }

        // [x] 2. at least 1 adjacent duplicate
        public bool atLeastOneAdjacent()
        {
            // Console.WriteLine("in atLeastOneAdjacent");
            for(int i = 0; i < potentialPwd.Length - 1; i++)
            {   // 1, 0, 0 
                if (potentialPwd[i] == potentialPwd[i+1])
                {
                    return true;
                }
            }

            return false;
        }

        // [x] 3. (n) <= (n+1)
        public bool allGreaterOrEqual()
        {
            // Console.WriteLine("in allGreaterOrEqual");
            
            for(int i = 0; i < potentialPwd.Length - 1; i++)
            {   // 1, 0, 0 
                if ((int)(potentialPwd[i] - '0') > (int)(potentialPwd[i+1] - '0'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

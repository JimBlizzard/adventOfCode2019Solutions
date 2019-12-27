using System;
using System.Collections.Generic;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\nNew run");

            int index0 = 0;
            int solutionValue = 0;

            List<int> sampleData0 = new List<int>{1,9,10,3,2,3,11,0,99,30,40,50};
            List<int> sampleData1 = new List<int>{1,0,0,0,99};
            List<int> sampleData2 = new List<int>{2,3,0,3,99};
            List<int> sampleData3 = new List<int>{2,4,4,5,99,0};
            List<int> sampleData4 = new List<int>{1,1,1,4,99,5,6,0,99};
            
            List<int> realData = new List<int> () {1,12,2,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,6,19,1,9,19,23,1,6,23,27,1,10,27,31,1,5,31,35,2,6,35,39,1,5,39,43,1,5,43,47,2,47,6,51,1,51,5,55,1,13,55,59,2,9,59,63,1,5,63,67,2,67,9,71,1,5,71,75,2,10,75,79,1,6,79,83,1,13,83,87,1,10,87,91,1,91,5,95,2,95,10,99,2,9,99,103,1,103,6,107,1,107,10,111,2,111,10,115,1,115,6,119,2,119,9,123,1,123,6,127,2,127,10,131,1,131,6,135,2,6,135,139,1,139,5,143,1,9,143,147,1,13,147,151,1,2,151,155,1,10,155,0,99,2,14,0,0};

            int realDataCount = realData.Count - 1;

            // outer loop noun 0 through count -1
            for (int noun = 0; noun < realDataCount; noun++ )
            {
                // inner loop verb 0 through count -1
                for (int verb = 0; verb < realDataCount; verb++)
                {
                    // int[] tempData = new int[realData.Count];
                    List<int> tempData = new List<int>(realData);
                    tempData[1] = noun;
                    tempData[2] = verb;

                    IntcodeProcessor ip = new IntcodeProcessor(tempData);
                    index0 = ip.ProcessData();
                    // Console.WriteLine("index0 is: {0}", index0);


                    if (index0 == 19690720) 
                    {
                        Console.WriteLine("found a match for 19690720!!!! ......  noun: {0}, verb: {1}", noun, verb); 
                        solutionValue = (100 * noun) + verb; 
                        Console.WriteLine("solution value is: {0}", solutionValue);

                    }

                }
            }
        }
    }

    class IntcodeProcessor
    {


        List<int> inputData;

        public IntcodeProcessor(List<int> data)
        {
            inputData = data;
        }

        public int ProcessData()
        {
            int calculationResult = 0;

            for (int i = 0; i < inputData.Count - 4 && inputData[i] != 99; i+=4)
            {
                // opCode is value of i
                // read position 1 is value of i+1
                // read position 2 is value of i+2
                // output position is value of i+3

                // opCode 1 = add
                // opCode 2 = multiply
                // opCode 99 = end

                // Console.WriteLine("========= Position in array is: {0}", i);

                // Console.WriteLine("i[0]: {0}, i[1]: {1}, i[2]: {2}, i[3]: {3}", inputData[i], inputData[i+1], inputData[i+2], inputData[i+3]);


                if (inputData[i] == 1) // add
                {
                    calculationResult = inputData[inputData[i+1]] + inputData[inputData[i+2]];
                    inputData[inputData[i+3]] = calculationResult;
                }
                else if (inputData[i] == 2) // multiply
                {
                    calculationResult = inputData[inputData[i+1]] * inputData[inputData[i+2]];
                    inputData[inputData[i+3]] = calculationResult;
                }
                else
                {
                        Console.WriteLine("Mysterious opCode received: {0}", inputData[i]);
                }

                // if (calculationResult == 19690720) 
                // {
                //     Console.WriteLine("found a match for 19690720!"); 
                // }
            }

            // Console.WriteLine("\n\n final array is: ");

            // for (int j = 0; j < inputData.Count; j++)
            // {
            //     Console.WriteLine("j: {0}, val: {1}", j, inputData[j]); 
            // }

            return inputData[0];
        }

    }

}

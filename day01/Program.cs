using System;
using System.Collections.Generic;

/*
    NOTE: This sample code is provided as is.
          No warranties implied or given. 
          This stuff is just for fun. 
          You can laugh if you want to.
*/
namespace day01
{
    class Program
    {
        private static int totalFuelNeeded = 0;
        static void Main(string[] args)
        {



            // var totalFuelNeeded = 0;
            // var moduleFuelNeeded = 0;
            // var fuelForModuleFuel = 0; 

            Console.WriteLine("Hello World!");

            List<int> input = new List<int> {
                121656,
                110933,
                80850,
                137398,
                76307,
                50450,
                124691,
                86449,
                145386,
                148648,
                68909,
                134697,
                109636,
                115718,
                134485,
                89267,
                64829,
                109070,
                84257,
                109010,
                97574,
                98363,
                123029,
                105568,
                114500,
                92041,
                128869,
                148350,
                144605,
                91862,
                134417,
                54710,
                147843,
                121914,
                127855,
                74545,
                89596,
                106562,
                69863,
                147082,
                135724,
                111637,
                68869,
                103685,
                99453,
                80908,
                136020,
                64974,
                125159,
                87504,
                62499,
                73294,
                128811,
                121567,
                54673,
                66647,
                66871,
                71228,
                101622,
                130675,
                69025,
                146118,
                79970,
                118267,
                122279,
                89523,
                62965,
                148036,
                119625,
                127056,
                54980,
                143581,
                103274,
                83064,
                125131,
                54362,
                115851,
                139103,
                140674,
                69616,
                81353,
                116441,
                73898,
                51403,
                137019,
                93146,
                67273,
                138182,
                126680,
                148683,
                127805,
                111741,
                102219,
                99603,
                90453,
                147581,
                102136,
                109913,
                144899,
                140572
            };

            List<int> testInput = new List<int> {
                100756
            };

            // Part 1 calculate total fuel requred for each of the modules
            foreach (var moduleMass in input)
            {
                Console.WriteLine(moduleMass);

                calcTotalFuelNeeded(moduleMass, ref totalFuelNeeded);

                // moduleFuelNeeded += Convert.ToInt32(Math.Floor(moduleMass / 3.0)) - 2;
                // totalFuelNeeded += moduleFuelNeeded;
            }
            Console.WriteLine("total mass needed: {0}", totalFuelNeeded);

            /* Part 2: 
               For each module mass, calculate its fuel and add it to the total. 
               Then, treat the fuel amount you just calculated as the input mass 
               and repeat the process, continuing until a fuel requirement is zero 
               or negative.
            */
        }

        static void calcTotalFuelNeeded(int mass, ref int fuelNeeded)
        {
            var f = Convert.ToInt32(Math.Floor(mass / 3.0)) - 2;
    
            if (f > 0) 
            {
                fuelNeeded += f;
                calcTotalFuelNeeded(f, ref fuelNeeded);
            }
        }
    }
}

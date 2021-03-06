﻿using System;
using System.Collections.Generic; 


/*
    NOTE: This sample code is provided as is.
          No warranties implied or given. 
          This stuff is just for fun. 
          You can laugh if you want to.
*/

namespace day03
{
    // Crossed wires

    class Program
    {
        static void Main(string[] args)
        {

            // string[] result; 

            // string wire1 = "D3,L3,R10,U10,D14,R10,L12";
            // string wire2 = "U5,R2,D3,R4";

            // string wire1 = "R3,U3";
            // string wire2 = "U5,R2,D3,R4";

            // // sample data 1 - should be 159
            // string wire1 = "R75,D30,R83,U83,L12,D49,R71,U7,L72";
            // string wire2 = "U62,R66,U55,R34,D71,R55,D58,R83";

            // // sample data 2 - should be 135
            // string wire1 = "R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51";
            // string wire2 = "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7";

            // real data
            string wire1 = "R1005,U370,L335,D670,R236,D634,L914,U15,R292,D695,L345,D183,R655,U438,R203,U551,L540,U51,R834,D563,L882,D605,L832,U663,R899,D775,L740,U764,L810,U442,R379,D951,L821,D703,R526,D624,L100,D796,R375,U129,L957,D41,R361,D504,R358,D320,L392,D842,R509,D612,L92,U788,L361,D757,R428,U257,L663,U956,L748,U938,R588,D942,R819,D732,R562,D331,L164,U801,R872,U872,L909,U260,R899,D278,R822,U968,L937,D594,L786,D34,R102,D650,R920,D539,R925,U436,R347,U686,L596,D608,R730,U5,R462,U831,R277,U411,R730,D828,L169,D276,L669,U167,R55,D879,L329,U258,R585,D134,R977,D609,L126,U848,L601,U624,R577,D421,L880,D488,R505,U385,L103,D693,L110,D338,R809,D864,L80,U413,R412,D134,L519,D988,R83,U580,R593,U435,R843,D953,R11,D655,R569,D237,R987,U894,L445,U974,L746,U450,R99,U69,R84,U258,L248,D581,R215,U306,R480,U126,R275,D353,R493,D800,L386,D876,L957,D722,L967,D612,L716,D901,R394,U764,R274,D686,L746,D957,R747,U517,L575,D961,R842,D753,L345,D59,L215,U413,R610,D166,L646,U107,L926,D848,R445,U297,L376,U869,L345,D529,R620,D353,R682,D908,R378,D221,R64,D911,L245,D364,R123,D555,L928,U412,R771,D543,L97,D477,R500,D125,R578,U150,R291,D252,R948,D576,L838,D144,L289,D677,L307,U692,R802,D743,R57,U839,R896,D110,R34,D508,L595,U658,L769,U47,L292,U66,R217,D8,L835,D479,L71,D24,R429,U64,R305,D406,R23,U819,R478,D7,L561,D503,R349,U104,L749,D123,R548,D421,R336,D837,R464,D908,L94,U988,L137,D757,L42,U842,R260,D406,L31,U965,L178,U973,L29,U276,L887,U920,L133,U243,R537,U282,R194,D152,R693,D509,L771,D365,L319,D378,L61,D849,R379";
            string wire2 = "L998,U242,R333,U631,L507,U313,R286,U714,R709,U585,R393,D893,R404,D448,R882,U246,L190,U238,R672,D184,L275,D120,R352,D584,L626,U413,L288,D942,R770,D551,L926,D242,R568,U48,R108,D349,R750,D323,L529,D703,L672,U775,L700,D465,L528,D596,R990,U366,L747,D270,L723,D469,L548,D47,L873,D678,R782,D187,L397,U975,R967,D224,L295,D86,L159,U610,L767,U641,L885,D623,L160,D509,R517,D981,L376,D604,R251,D140,L938,D358,L984,U63,R513,D54,L718,U90,L343,D982,L575,D692,L508,D361,L297,D880,L46,D875,R40,D97,R819,U919,R319,U152,R161,U553,L388,D100,R481,U306,L201,U706,L173,D657,L632,D182,R477,D332,R678,D683,L983,D584,R941,U801,R485,D376,R218,D432,R780,D617,R560,D618,R466,U456,L952,D72,R339,U16,L543,U176,L423,D770,L714,U621,L850,U929,R132,D908,R993,U440,R539,U374,L945,D443,L326,D651,L269,U321,R925,D777,R431,U273,R811,D63,R683,D540,L3,D617,R359,U332,L736,D98,L859,D994,R131,U71,L156,D661,R879,D303,L581,U407,L166,U878,L831,D871,R953,D137,L903,U200,R34,D857,R448,D412,L311,D212,R527,D707,R641,D775,L987,D814,L38,D96,R647,U868,L98,U882,L838,D308,R840,U161,R83,U424,L420,U934,R353,D287,R559,D665,R695,D888,R859,U992,L283,D525,L449,U255,L889,D296,R72,D899,R316,D3,L308,D404,L356,D333,R645,U274,R336,U258,R599,U746,L142,U21,R301,D890,L290,D624,R565,U117,L927,U412,L687,U480,R674,U372,L382,D134,L372,D892,R307,U217,L20,D535,L876,D548,L19,U590,R906,D816,R465,U768,R882,U980,L557,D788,R645,U684,L255,D803,L374,U759,L693,D92,L256,U772,R591,D126,R57,U363,R347,U191,L760,U223,R591,D507,R232,U251,R471,D912,R227";

            // these arrays hold the locations of the wire
            string[] wireALocations;
            string[] wireBLocations;

            Console.WriteLine("\n\n\nNew run");

            // convert the input strings into arrays
            wireALocations = wire1.Split(",", StringSplitOptions.RemoveEmptyEntries);
            wireBLocations = wire2.Split(",", StringSplitOptions.RemoveEmptyEntries);
 
            CrossedWiresCalculator cwc = new CrossedWiresCalculator();

            // Create the list of points for each wire 
            cwc.WireAPoints = cwc.BuildWirePoints(wireALocations);
            cwc.WireBPoints = cwc.BuildWirePoints(wireBLocations);

            int closestPointDistance = Int32.MaxValue;
            int currentPointDistance = Int32.MaxValue;

            Console.WriteLine("\nNumber of points for wireA: {0} and wireB: {1}", cwc.WireAPoints.Count, cwc.WireBPoints.Count); 

            DateTime startTime = DateTime.Now; 
            DateTime endTime; 

            // First mvp attempt used an array for all wire points of each wire, which meant looping A ** B times. 
            // Needless to say, it was a bit slow... as in, about 9 minutes to run with the real data. ;) 
            // Using dictionaries takes less than a second to get the results.

            // Determine if any point on wire A is also in wire B. 
            // We want to find the smallest (closest) one to the origin (0,0)
            // To do this, loop through wire A's points and see if there's a match in wire B.
            int lowestNumSteps = Int32.MaxValue;

            foreach(KeyValuePair<string, Point> pointA  in cwc.WireAPoints)
            {
                // Exclude point 0,0
                if (pointA.Key != "0,0")
                {
                    var pointB = cwc.WireBPoints.GetValueOrDefault(pointA.Key);

                    // See if wire A key matches any key in Wire B
                    if (pointB != null) // in a match...
                    {
                        currentPointDistance = Math.Abs(pointA.Value.X) + Math.Abs(pointA.Value.Y);
                        if (currentPointDistance < closestPointDistance)
                        {
                            Console.WriteLine("\nPoint ({1}, {2})", pointA.Value.X, pointA.Value.Y, pointA.Value.Steps); 
                            closestPointDistance = currentPointDistance;
                        }

                        // we have a crossing wire. find the number of steps for both wires. determine smallest number of steps by
                        // summing the steps pointA.Value.steps + pointB.steps
                        var numSteps = pointA.Value.Steps + pointB.Steps;

                        Console.WriteLine("\nSteps: {2}", pointA.Value.X, pointA.Value.Y, numSteps); 
                        if (numSteps < lowestNumSteps)
                        {
                            Console.WriteLine("\nNew Lowest Steps: {2}", pointA.Value.X, pointA.Value.Y, numSteps); 
                            lowestNumSteps = numSteps;
                        }
                    }

                }
            }

            Console.WriteLine("\nClosest point distance is ****** {0} ******", closestPointDistance);
            Console.WriteLine("\nLowest steps is {0}", lowestNumSteps);
            endTime = DateTime.Now; 

            Console.WriteLine("\nStart time: {0}", startTime);
            Console.WriteLine("End time:   {0}", endTime);

        }

    }

    

    public class CrossedWiresCalculator
    {

        // yeah, i'm exposing my privates in public. these should be put into properties

        public Dictionary<string,Point> WireAPoints;
        public Dictionary<string,Point> WireBPoints;
        

        public CrossedWiresCalculator()
        {
            WireAPoints = new Dictionary<string,Point>();
            WireBPoints = new Dictionary<string,Point>();
        }


         // Create a dictionary of x/y points in a wire given its wire locations
        public Dictionary<string, Point> BuildWirePoints(string[] wireLengths)
        {

            Dictionary<string, Point> wirePoints = new Dictionary<string, Point>(); 

            string nextPointDirection; 
            int nextPointDistance;


            // Console.WriteLine("\n\nBuildWirePoints");
            
            int currentX = 0;
            int currentY = 0;
            int steps = 0;

            wirePoints.Add((currentX.ToString() + "," + currentY.ToString()), new Point(currentX,currentY, steps));


            for (int i = 0; i < wireLengths.Length; i++)
            {
                nextPointDirection = wireLengths[i].Substring(0,1);

                if (Int32.TryParse(wireLengths[i].Substring(1,wireLengths[i].Length-1), out int npdistance))
                {
                    nextPointDistance = npdistance;
                }
                else
                {
                    Console.WriteLine("unknown location");
                    nextPointDistance = 99999;
                };

                // Console.WriteLine("next point direction: {0}, distance: {1}", nextPointDirection, nextPointDistance);
                
                switch (nextPointDirection)
                {
                    case "R": 
                        // Console.WriteLine("moving to the right: {0}", nextPointDistance);
                        for (int moveNumber = 0; moveNumber < nextPointDistance; moveNumber++)
                        {
                            currentX++;
                            steps++;
                            // Console.WriteLine("{2} adding point {0}, {1}", currentX, currentY, moveNumber);
                            addNewKeyToWirePoints(currentX, currentY, steps, ref wirePoints);
                        }
                        break;

                    case "L": 
                        // Console.WriteLine("moving to the left: {0}", nextPointDistance);
                        for (int moveNumber = 0; moveNumber < nextPointDistance; moveNumber++)
                        {
                            currentX--;
                            steps++;
                            // Console.WriteLine("{2} adding point {0}, {1}", currentX, currentY, moveNumber);
                            addNewKeyToWirePoints(currentX, currentY, steps, ref wirePoints);
                        }
                        break;

                    case "U": 
                        // Console.WriteLine("moving up: {0}", nextPointDistance);
                        for (int moveNumber = 0; moveNumber < nextPointDistance; moveNumber++)
                        {
                            currentY++;
                            steps++;
                            addNewKeyToWirePoints(currentX, currentY, steps, ref wirePoints);
                        }
                        break;
                    case "D": 
                        // Console.WriteLine("moving down: {0}", nextPointDistance);
                        for (int moveNumber = 0; moveNumber < nextPointDistance; moveNumber++)
                        {
                            currentY--;
                            steps++;
                            // Console.WriteLine("{2} adding point {0}, {1}", currentX, currentY, moveNumber);
                            addNewKeyToWirePoints(currentX, currentY, steps, ref wirePoints);
                        }
                        break;
                }

            }

            return wirePoints;

        }         

        private void addNewKeyToWirePoints(int curX, int curY, int steps, ref Dictionary<string, Point> wp)
        {
            string nk; 

            nk = curX.ToString() + "," + curY.ToString();
            if (!wp.ContainsKey(nk))
            {
                wp.Add((nk), new Point(curX, curY, steps));
            }
        }       
    }

    public class Point
    {
        public int X { get;  }
        public int Y { get;  }
        public int Steps {get; }

        public Point(int x, int y, int s)
        {
            this.X = x; 
            this.Y = y;
            this.Steps = s;
        }
    }
}


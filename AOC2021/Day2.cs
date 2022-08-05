using System;
using System.Collections.Generic;
using System.Text;

namespace AOC2021
{
    internal class Day2 : IAOCDay
    {
        public int Puzzle1()
        {
            string[] input = System.IO.File.ReadAllLines(@"..\..\..\input\2-1.txt");
            int horizontalPosition = 0;
            int depth = 0;

            foreach (string line in input)
            {
                string[] command = line.Split(' ');
                switch (command[0])
                {
                    case "forward":
                        horizontalPosition += int.Parse(command[1]);
                        break;
                    case "down":
                        depth += int.Parse(command[1]);
                        break;
                    case "up":
                        depth -= int.Parse(command[1]);
                        break;
                }
            }
            return depth * horizontalPosition;
        }

        public int Puzzle2()
        {
            string[] input = System.IO.File.ReadAllLines(@"..\..\..\input\2-2.txt");
            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;

            foreach (string line in input)
            {
                string[] command = line.Split(' ');
                switch (command[0])
                {
                    case "forward":
                        horizontalPosition += int.Parse(command[1]);
                        depth += aim * int.Parse(command[1]);
                        break;
                    case "down":
                        aim += int.Parse(command[1]);
                        break;
                    case "up":
                        aim -= int.Parse(command[1]);
                        break;
                }
            }
            return depth * horizontalPosition;
        }
    }
}

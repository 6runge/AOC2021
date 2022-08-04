namespace AOC2021
{
    class Day1 : IAOCDay
    {
        public int Puzzle1()
        {
            string[] input = System.IO.File.ReadAllLines(@"..\..\..\input\1-1.txt");
            int increases = 0;
            int previousDepth = -1;
            foreach (string line in input)
            {
                int currentDepth = int.Parse(line);
                if (currentDepth > previousDepth && previousDepth != -1)
                {
                    increases++;
                }
                previousDepth = currentDepth;
            }
            return increases;
        }

        public int Puzzle2()
        {
            string[] input = System.IO.File.ReadAllLines(@"..\..\..\input\1-2.txt");
            int increases = 0;
            for (int i = 0; i < input.Length - 3; i++)
            {
                int currentWindow = int.Parse(input[i]) + int.Parse(input[i + 1]) + int.Parse(input[i + 2]);
                int nextWindow = int.Parse(input[i+1]) + int.Parse(input[i + 2]) + int.Parse(input[i + 3]);

                if(nextWindow > currentWindow)
                {
                    increases++;
                }
            }
            return increases;
        }
    }
}
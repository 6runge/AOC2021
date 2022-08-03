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
            return -1;
        }
    }
}
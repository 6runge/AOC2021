using System;

namespace AOC2021
{
    class Program
    {
        private static IAOCDay[] _solvers = new IAOCDay[]
            {
                new Day1(),
                new Day2()
            };

        static void Main(string[] args)
        {
            Tuple<int, int> pickedPuzzle = CalculateToPickedPuzzle(PromptUserPick(_solvers));
            int solution = SolvePuzzle(pickedPuzzle);
            Console.WriteLine("The solution to the puzzle you picked:");
            Console.WriteLine(solution);
        }

        private static Tuple<int, int> CalculateToPickedPuzzle(int userPick)
        {
            Console.WriteLine($"You picked puzzle {userPick}");
            int dayPick = ((userPick + 1) / 2) - 1;
            int puzzlePick = userPick % 2;
            return new Tuple<int, int>(dayPick, puzzlePick);
        }

        private static int SolvePuzzle(Tuple<int, int> pickedPuzzle)
        {
            IAOCDay daySolver = _solvers[pickedPuzzle.Item1];
            int solution;
            if (pickedPuzzle.Item2 == 1)
            {
                solution = daySolver.Puzzle1();
            }
            else
            {
                solution = daySolver.Puzzle2();
            }

            return solution;
        }

        private static int PromptUserPick(IAOCDay[] puzzleSolvers)
        {
            Console.WriteLine("Pick a Puzzle:");
            for (int i = 0; i < puzzleSolvers.Length; i++)
            {
                int index = i * 2 + 1;
                Console.WriteLine($"{index}: Day {i + 1}, Puzzle 1");
                Console.WriteLine($"{index + 1}: Day {i + 1}, Puzzle 2");
            }
            string inputString = Console.ReadLine();
            int puzzleIndex;
            try
            {
                puzzleIndex = int.Parse(inputString);
            }
            catch (FormatException)
            {
                Console.WriteLine("Illegal input. Please just type the number of the puzzle you want solved.");
                puzzleIndex = PromptUserPick(puzzleSolvers);
            }
            if (puzzleIndex < 1)
            {
                Console.WriteLine("Illegal input. Try a bigger number.");
                puzzleIndex = PromptUserPick(puzzleSolvers);
            }
            else if (puzzleIndex > puzzleSolvers.Length * 2)
            {
                Console.WriteLine("Illegal input. Try a smaller number.");
                puzzleIndex = PromptUserPick(puzzleSolvers);
            }
            return puzzleIndex;
        }
    }
}

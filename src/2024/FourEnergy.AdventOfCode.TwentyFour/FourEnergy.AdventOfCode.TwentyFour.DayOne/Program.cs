using FourEnergy.AdventOfCode.Y2024.Day03;
using FourEnergy.AdventOfCode.Y2024.Services;

namespace FourEnergy.AdventOfCode.Y2024;

internal class Program
{
    static void Main()
    {
        var input = FileHandler.Load("Day03/Input.txt");
        var answer = Day3Riddle2.Solve(input);

        Console.WriteLine(answer);
    }
}

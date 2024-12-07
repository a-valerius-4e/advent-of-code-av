using FourEnergy.AdventOfCode.Y2024.Day01;
using FourEnergy.AdventOfCode.Y2024.Services;

namespace FourEnergy.AdventOfCode.Y2024;

internal class Program
{
    static void Main()
    {
        var input = FileHandler.Load("Day01/Input.txt");
        var answer = Day1Riddle2.Solve(input);

        Console.WriteLine(answer);
    }
}

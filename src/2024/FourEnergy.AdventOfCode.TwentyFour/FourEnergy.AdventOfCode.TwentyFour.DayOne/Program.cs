using FourEnergy.AdventOfCode.Y2024.Day02;
using FourEnergy.AdventOfCode.Y2024.Services;

namespace FourEnergy.AdventOfCode.Y2024;

internal class Program
{
    static void Main()
    {
        var input = FileHandler.Load("Day02/Input.txt");
        var answer = Day2Riddle2.Solve(input);

        Console.WriteLine(answer);
    }
}

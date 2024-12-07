using System.Text.RegularExpressions;

namespace FourEnergy.AdventOfCode.Y2024.Day03;

internal static partial class Day3Riddle1
{
    public static string Solve(string input)
    {
        var result =
            MulFindingRegex()
            .Matches(input)
            .Select(match => match.Value)
            .Select(op => op.Split(","))
            .Select(op => new Tuple<string, string>(DigitsRegex().Match(op[0]).Value, DigitsRegex().Match(op[1]).Value))
            .Select(op => new Tuple<int, int>(int.Parse(op.Item1), int.Parse(op.Item2)))
            .Select(op => op.Item1 * op.Item2)
            .Sum();

        return result.ToString();
    }

    [GeneratedRegex(@"mul\(\d{1,3}\,\d{1,3}\)")]
    internal static partial Regex MulFindingRegex();
    [GeneratedRegex(@"\d+")]
    internal static partial Regex DigitsRegex();
}

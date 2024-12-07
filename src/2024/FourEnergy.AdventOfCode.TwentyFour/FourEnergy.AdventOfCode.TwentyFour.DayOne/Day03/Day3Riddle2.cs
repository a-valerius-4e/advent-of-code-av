using System.Text.RegularExpressions;
using static FourEnergy.AdventOfCode.Y2024.Day03.Day3Riddle1;

namespace FourEnergy.AdventOfCode.Y2024.Day03;

internal static partial class Day3Riddle2
{
    public static string Solve(string input)
    {
        var doStatements = input
            .Split("do()")
            .ToList()
            .Select(x => x.Contains("don't()") ? x.Substring(0, x.IndexOf("don't()")) : x)
            .Aggregate((a, b) => a + b);


        var result =
            MulFindingRegex()
            .Matches(doStatements)
            .Select(match => match.Value)
            .Select(op => op.Split(","))
            .Select(op => new Tuple<string, string>(DigitsRegex().Match(op[0]).Value, DigitsRegex().Match(op[1]).Value))
            .Select(op => new Tuple<int, int>(int.Parse(op.Item1), int.Parse(op.Item2)))
            .Select(op => op.Item1 * op.Item2)
            .Sum();

        return result.ToString();
    }


    [GeneratedRegex(@"do\(\)")]
    internal static partial Regex DoFindingRegex();
    [GeneratedRegex(@"don't\(\)")]
    internal static partial Regex DontFindingRegex();
}

using System.Text.RegularExpressions;

namespace FourEnergy.AdventOfCode.Y2024.Day01;

internal static partial class Day1Riddle1
{
    public static string Solve(string input)
    {
        var rows = input.Split("\r\n");
        var leftList = rows.Select(l => int.Parse(LeftListRegex().Match(l).Value)).Order().ToArray();
        var rightList = rows.Select(l => int.Parse(RightListRegex().Match(l).Value)).Order().ToArray();

        var distance = 0;
        for (int i = 0; i < leftList.Length; i++)
        {
            distance += Math.Abs(leftList[i] - rightList[i]);
        }

        return distance.ToString();
    }

    [GeneratedRegex(@"^\d+")]
    internal static partial Regex LeftListRegex();
    [GeneratedRegex(@"\d+$")]
    internal static partial Regex RightListRegex();
}

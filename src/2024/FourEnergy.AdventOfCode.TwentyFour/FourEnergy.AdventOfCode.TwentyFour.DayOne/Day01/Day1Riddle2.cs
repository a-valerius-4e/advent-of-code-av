using static FourEnergy.AdventOfCode.Y2024.Day01.Day1Riddle1;

namespace FourEnergy.AdventOfCode.Y2024.Day01;

internal static class Day1Riddle2
{
    public static string Solve(string input)
    {
        var rows = input.Split("\r\n");
        var leftList = rows.Select(l => int.Parse(LeftListRegex().Match(l).Value)).Order().ToArray();
        var rightList = rows.Select(l => int.Parse(RightListRegex().Match(l).Value)).Order().ToArray();

        var similarityScore = 0;
        foreach (var number in leftList)
        {
            var appearances = rightList.Where(number.Equals).Count();
            similarityScore += appearances * number;
        }

        return similarityScore.ToString();
    }

}

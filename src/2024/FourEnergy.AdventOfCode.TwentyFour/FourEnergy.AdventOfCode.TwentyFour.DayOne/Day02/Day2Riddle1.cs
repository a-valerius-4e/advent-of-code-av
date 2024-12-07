namespace FourEnergy.AdventOfCode.Y2024.Day02;

internal static class Day2Riddle1
{
    public static string Solve(string input)
    {
        var rows = input.Split("\r\n");
        var safeReportsCount = 0;
        foreach (var report in rows)
        {
            var levels = report.Split(" ").Select(l => int.Parse(l)).ToArray();
            var direction = levels[0] < levels[1] ? Direction.Increasing : Direction.Decreasing;
            bool isSafe = true;
            for (var i = 0; i < levels.Length - 1; i++)
            {
                var localDirection = levels[i] < levels[i + 1] ? Direction.Increasing : Direction.Decreasing;
                var distance = Math.Abs(levels[i] - levels[i + 1]);
                if (localDirection != direction || distance == 0 || distance > 3)
                {
                    isSafe = false;
                }
            }
            if (isSafe)
            {
                safeReportsCount++;
            }
        }

        return safeReportsCount.ToString();
    }
}

internal enum Direction
{
    Increasing,
    Decreasing
}

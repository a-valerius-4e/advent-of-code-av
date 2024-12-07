namespace FourEnergy.AdventOfCode.Y2024.Services;

internal static class FileHandler
{
    public static string Load(string path)
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("Die Datei existiert nicht");
            return string.Empty;
        }
        return File.ReadAllText(path);
    }
}

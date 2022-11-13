using System.Collections.Immutable;
using static System.Console;
using static System.String;


namespace HW10;

internal class Program
{
    public static void Main(string[] args)
    {
        var pupil = FileReader("C:\\Beet_lessons\\HW10\\DB\\Pupils.txt");
    
        WriteLine("Search: ");
        WriteLine($"Input pupil name");
        var list = Search(ReadLine(), pupil);
        WriteLine("Search result: ");

        WriteLine(
            $"{(list.Any() ? $"{Join("\r\n", list.ToImmutableSortedSet())}" : "The pupil isn't this school")}");
               

        (string, string, string)[] Search(string input, List<(string, string, string)> collection) =>
            collection.Where(person =>
                person.Item1.Contains(input, StringComparison.OrdinalIgnoreCase) ||
                person.Item2.Contains(input, StringComparison.OrdinalIgnoreCase) ||
                person.Item3.Contains(input)).ToArray();
    }

    private static List<(string Name, string Surname, string Age)> FileReader(string path)
    {
        var lines = File.ReadAllLines("C:\\Beet_lessons\\HW10\\DB\\Pupils.txt");
        return lines.Select(line => line.Split(",")).Select(split => (split[0], split[1], split[2])).ToList();
    }
}
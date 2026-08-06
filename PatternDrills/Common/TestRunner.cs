namespace AlgoPatternDrills.Common;

public static class TestRunner
{
    public static int Run(string pattern, IReadOnlyList<DrillCase> drills, string selection)
    {
        IEnumerable<DrillCase> selected;

        if (selection.Equals("all", StringComparison.OrdinalIgnoreCase))
        {
            selected = drills;
        }
        else if (int.TryParse(selection, out int number))
        {
            selected = drills.Where(x => x.Number == number);

            if (!selected.Any())
            {
                Console.Error.WriteLine($"Unknown drill {number} for {pattern}.");
                return 2;
            }
        }
        else
        {
            Console.Error.WriteLine("Choose a drill number from 1 to 8, or use 'all'.");
            return 2;
        }

        int passed = 0;
        int todo = 0;
        int failed = 0;

        foreach (DrillCase drill in selected)
        {
            try
            {
                drill.Run();
                Console.WriteLine($"PASS  {pattern} {drill.Number}: {drill.Name}");
                passed++;
            }
            catch (NotImplementedException)
            {
                Console.WriteLine($"TODO  {pattern} {drill.Number}: {drill.Name}");
                todo++;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"FAIL  {pattern} {drill.Number}: {drill.Name}");
                Console.WriteLine($"      {exception.Message}");
                failed++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Passed: {passed}  TODO: {todo}  Failed: {failed}");
        return failed == 0 ? 0 : 1;
    }
}

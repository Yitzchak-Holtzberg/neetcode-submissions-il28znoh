using AlgoPatternDrills.Common;
using AlgoPatternDrills.Tests;

var patterns = new Dictionary<string, (string Name, Func<IReadOnlyList<DrillCase>> Drills)>(
    StringComparer.OrdinalIgnoreCase)
{
    ["arrays-hashing"] = ("Arrays and hashing", ArraysHashingTests.All),
    ["two-pointers"] = ("Two pointers", TwoPointersTests.All),
    ["stack-queue"] = ("Stacks and queues", StackQueueTests.All),
    ["linked-lists"] = ("Linked lists", LinkedListsTests.All),
    ["binary-search"] = ("Binary search", BinarySearchTests.All),
    ["sorting-heaps"] = ("Sorting and heaps", SortingHeapsTests.All),
    ["tree-dfs-bst"] = ("Tree DFS and BST", TreeDfsBstTests.All),
    ["tree-bfs"] = ("Tree BFS", TreeBfsTests.All)
};

if (args.Length == 0 || args[0].Equals("list", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Pattern drills");
    Console.WriteLine();

    foreach ((string key, var value) in patterns)
    {
        Console.WriteLine($"{key,-18} {value.Name}");

        foreach (DrillCase drill in value.Drills())
            Console.WriteLine($"  {drill.Number}. {drill.Name}");
    }

    Console.WriteLine();
    Console.WriteLine("Run one: dotnet run -- arrays-hashing 1");
    Console.WriteLine("Run a set: dotnet run -- tree-bfs all");
    Console.WriteLine("Run all: dotnet run -- all");
    return;
}

if (args[0].Equals("all", StringComparison.OrdinalIgnoreCase))
{
    int failures = 0;

    foreach ((string key, var value) in patterns)
    {
        Console.WriteLine($"=== {value.Name} ===");
        int result = TestRunner.Run(key, value.Drills(), "all");

        if (result != 0)
            failures++;
    }

    Environment.ExitCode = failures == 0 ? 0 : 1;
    return;
}

if (!patterns.TryGetValue(args[0], out var pattern))
{
    Console.Error.WriteLine($"Unknown pattern '{args[0]}'. Run 'dotnet run -- list'.");
    Environment.ExitCode = 2;
    return;
}

string selection = args.Length >= 2 ? args[1] : "all";
Environment.ExitCode = TestRunner.Run(args[0], pattern.Drills(), selection);

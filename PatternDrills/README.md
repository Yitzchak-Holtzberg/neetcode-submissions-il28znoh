# C# Algorithm Pattern Drills

A reconstruction course for syntax and pattern fluency.

This project is based on the work already present in the adjacent NeetCode submissions repository. It concentrates the material into eight clusters and gives each cluster:

- one complete reference implementation;
- eight small variations;
- executable tests;
- a command that runs only the drill currently being written.

The tests treat `NotImplementedException` as `TODO`, so unfinished drills stay quiet instead of turning the whole repository red.

## Start

```bash
cd PatternDrills
dotnet run -- list
dotnet run -- arrays-hashing 1
dotnet run -- tree-dfs-bst 4
dotnet run -- tree-bfs all
dotnet run -- all
```

A passing drill prints `PASS`. An untouched method prints `TODO`. A wrong answer prints `FAIL` with the first failed assertion.

## The training rule

For each pattern:

1. Read the worked sample once.
2. Hide it.
3. Implement drill 1 from a blank method.
4. Run that drill.
5. Delete and rewrite the machinery once after it passes.
6. Move to drill 2.
7. Re-run the entire pattern the next day.

Do not copy the reference method and rename variables. The point is retrieval.

## C# syntax sheet

```csharp
array.Length
text.Length
list.Count
stack.Count
queue.Count

stack.Push(value);
stack.Pop();
stack.Peek();

queue.Enqueue(value);
queue.Dequeue();
queue.Peek();

dictionary.GetValueOrDefault(key)
hashSet.Add(value)
```

## Pattern map

### 1. Arrays and hashing

Worked sample: build a frequency map.

1. Contains duplicate
2. Valid anagram
3. Two sum
4. First repeated value
5. Most frequent value
6. Unique intersection
7. Unique frequencies
8. Longest consecutive sequence

```bash
dotnet run -- arrays-hashing 1
```

### 2. Two pointers

Worked sample: exact palindrome.

1. Loose palindrome
2. Reverse characters
3. Pair sum in sorted array
4. Move zeros
5. Remove target
6. Sorted squares
7. Merge sorted arrays
8. Sort colours

```bash
dotnet run -- two-pointers 1
```

### 3. Stacks and queues

Worked sample: valid parentheses.

1. Valid parentheses
2. Evaluate postfix
3. Baseball score
4. Remove adjacent duplicates
5. Next greater value
6. Students unable to eat
7. Sliding-window maximum
8. Days until warmer

```bash
dotnet run -- stack-queue 1
```

### 4. Linked lists

Worked sample: reverse a list.

1. Reverse list
2. Merge sorted lists
3. Middle node
4. Cycle detection
5. Remove nth from end
6. Delete sorted duplicates
7. Palindrome list
8. Reorder list

```bash
dotnet run -- linked-lists 1
```

### 5. Binary search

Worked sample: exact search.

1. Exact search
2. First occurrence
3. Last occurrence
4. Lower bound
5. Search insert position
6. Search matrix
7. Integer square root
8. Minimum eating speed

```bash
dotnet run -- binary-search 1
```

### 6. Sorting and heaps

Worked sample: insertion sort.

1. Insertion sort
2. Merge sort
3. Kth largest
4. Top-k frequent
5. K closest points
6. Merge k sorted arrays
7. Merge intervals
8. Minimum connection cost

```bash
dotnet run -- sorting-heaps 1
```

### 7. Tree DFS and BST

Worked sample: recursive preorder DFS.

1. Preorder
2. Inorder
3. Postorder
4. Maximum depth
5. Same tree
6. Invert tree
7. Insert into BST
8. Validate BST

```bash
dotnet run -- tree-dfs-bst 1
```

### 8. Tree BFS

Worked sample: level-order traversal.

1. Level order
2. Right-side view
3. Average of levels
4. Minimum depth
5. Zigzag order
6. Largest value per level
7. Deepest leaves sum
8. Cousins

```bash
dotnet run -- tree-bfs 1
```

## Suggested order

Start with the syntax-heavy structures rather than the hardest problems:

1. Binary search
2. Tree DFS and BST
3. Tree BFS
4. Stacks and queues
5. Two pointers
6. Linked lists
7. Arrays and hashing
8. Sorting and heaps

The first three directly attack the recall problem: boundaries, recursion, `Stack<T>`, `Queue<T>`, `Count`, `Enqueue`, `Dequeue`, and level snapshots.

## Resetting a drill

Git makes repetition cheap:

```bash
git restore Patterns/TreeBfs.cs
```

For a useful rewrite, commit the passing version first, then delete only the method body and reconstruct it without looking.

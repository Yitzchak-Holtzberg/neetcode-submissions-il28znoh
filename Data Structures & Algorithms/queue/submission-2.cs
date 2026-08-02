class Deque
{
    private readonly LinkedList<int> prim;

    public Deque()
    {
        prim = new LinkedList<int>();
    }

    public bool isEmpty()
    {
        return prim.Count == 0;
    }

    public void append(int value)
    {
        prim.AddLast(value);
    }

    public void appendleft(int value)
    {
        prim.AddFirst(value);
    }

    public int pop()
    {
        if (prim.Count == 0)
        {
            return -1;
        }

        int last = prim.Last!.Value;
        prim.RemoveLast();

        return last;
    }

    public int popleft()
    {
        if (prim.Count == 0)
        {
            return -1;
        }

        int first = prim.First!.Value;
        prim.RemoveFirst();

        return first;
    }
}
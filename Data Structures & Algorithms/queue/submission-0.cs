class Deque {
    List<int> prim;

    public Deque() {
        prim = new List<int>();
    }

    public bool isEmpty() {
        return prim.Count() == 0;
    }

    public void append(int value) {
        prim.Add(value);
    }

    public void appendleft(int value) {
        prim.Insert(0, value);
    }

    public int pop() {
        if (prim.Count() == 0) {
            return -1;
        }
        int last = prim[^1];
        prim.RemoveAt(prim.Count - 1);
        return last;
    }

    public int popleft() {
        if (prim.Count() == 0) {
            return -1;
        }
        int first = prim.First();
        prim.RemoveAt(0);
        return first;
    }
}

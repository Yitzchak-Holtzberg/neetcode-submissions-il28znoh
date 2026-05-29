public class MinStack {
    private List<int> stack;
    private List<int> mins;

    public MinStack() {
        stack = new List<int>();
        mins  = new List<int>();
    }

    public void Push(int val) {
        stack.Add(val);
        mins.Add(mins.Count == 0 ? val : Math.Min(val, mins[^1]));
    }

    public void Pop() {
        stack.RemoveAt(stack.Count - 1);
        mins.RemoveAt(mins.Count - 1);
    }

    public int Top() {
        return stack[^1];
    }

    public int GetMin() {
        return mins[^1];
    }
}
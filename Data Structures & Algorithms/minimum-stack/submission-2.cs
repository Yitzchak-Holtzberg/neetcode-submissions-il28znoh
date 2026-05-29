public class MinStack {
    private List<int?> stack;
    private int currentIndex;
    public MinStack() {
        stack = new List<int?>();
        currentIndex = -1;
    }

    public void Push(int val) {
        currentIndex++;
        if (currentIndex < stack.Count)
            stack[currentIndex] = val;
        else
            stack.Add(val);
    }

    public void Pop() {
        stack[currentIndex] = null;
        currentIndex--;
    }

    public int Top() {
        return stack[currentIndex].Value;
    }

    public int GetMin() {
        return stack.Min().Value;
    }
}

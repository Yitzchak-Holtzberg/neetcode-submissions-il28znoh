public class MinStack {
    private int[] stack;
    private int[] mins;
    private int size;

    public MinStack() {
        stack = new int[16];
        mins = new int[16];
        size = 0;
    }

    public void Push(int val) {
        if (size == stack.Length) {
            Array.Resize(ref stack, size * 2);
            Array.Resize(ref mins, size * 2);
        }
        stack[size] = val;
        mins[size] = size == 0 ? val : Math.Min(val, mins[size - 1]);
        size++;
    }

    public void Pop() => size--;
    public int Top() => stack[size - 1];
    public int GetMin() => mins[size - 1];
}
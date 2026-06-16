public class MyStack {
    public Stack<int> mine;

    public MyStack() {
        mine = new Stack<int>();
    }

    public void Push(int x) {
        mine.Push(x);
    }

    public int Pop() {
        return mine.Pop();
    }

    public int Top() {
        return mine.Peek();
    }

    public bool Empty() {
        return mine.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
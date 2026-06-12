public class BrowserHistory {
    private LinkedList<string> history;
    private LinkedListNode<string> curr;

    public BrowserHistory(string homepage) {
        history = new LinkedList<string>();
        curr = history.AddLast(homepage);
    }

    public void Visit(string url) {
        if (history.First == null)
            curr = history.AddLast(url);

        while (curr.Next != null) history.RemoveLast();

        curr = history.AddLast(url);
    }

    public string Back(int steps) {
        for (int i = 0; i < steps; i++) {
            if (curr.Previous == null) {
                return curr.Value;
            }
            curr = curr.Previous;
        }
        return curr.Value;
    }

    public string Forward(int steps) {
        for (int i = 0; i < steps; i++) {
            if (curr.Next == null) {
                return curr.Value;
            }
            curr = curr.Next;
        }
        return curr.Value;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */
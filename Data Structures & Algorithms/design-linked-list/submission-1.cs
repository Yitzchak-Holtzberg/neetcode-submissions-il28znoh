public class MyLinkedList {
    Node first;
    int count;
    class Node {
        public int Value;
        public Node Next;
        public Node Prev;

        public Node(int value) {
            Value = value;
            Next = null;
            Prev = null;
        }
    }

    public MyLinkedList() {
        first = null;
        count = 0;
    }

    public int Get(int index) {
        if (index < 0 || index >= count)
            return -1;

        var current = first;

        for (int i = 0; i < index; i++) {
            current = current.Next;
        }

        return current.Value;
    }

    public void AddAtHead(int val) {
        if (first == null) {
            first = new Node(val);
        } else {
            var temp = first;
            var newOne = new Node(val);
            newOne.Next = first;
            temp.Prev = newOne;
            first = newOne;
        }
        count++;
    }

    public void AddAtTail(int val) {
        var newOne = new Node(val);

        if (first == null) {
            first = newOne;
        } else {
            var current = first;
            while (current.Next != null) current = current.Next;
            newOne.Prev = current;
            current.Next = newOne;
        }

        count++;
    }

    public void AddAtIndex(int index, int val) {
        var newOne = new Node(val);

        if (index < 0 || index > count)
            return;

        if (index == 0) {
            AddAtHead(val);
            return;
        } else if (index == count) {
            AddAtTail(val);
            return;
        }

        var current = first;

        for (int i = 0; i < index; i++) {
            current = current.Next;
        }

        newOne.Prev = current.Prev;
        newOne.Next = current;
        current.Prev.Next = newOne;
        current.Prev = newOne;
        count++;
    }

    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= count)
            return;


        if (index == 0) {
            first = first.Next;
            if (first != null) first.Prev = null;
        } else {
            var cur = first;
            for (int i = 0; i < index; i++) cur = cur.Next;
            
            cur.Prev.Next = cur.Next;
            if (cur.Next != null) {
                cur.Next.Prev = cur.Prev;
            }
        }
        count--;
    }



    public List<int> GetValues() {
        var result = new List<int>();

        if (first == null) {
            return new List<int>();
        }
        var current = first;
        while (true) {
            result.Add(current.Value);
            if (current.Next != null) {
                current = current.Next;
            } else {
                return result;
            }
        }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
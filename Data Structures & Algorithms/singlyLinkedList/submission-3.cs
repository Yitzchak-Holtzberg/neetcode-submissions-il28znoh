public class LinkedList {
    Node first;
    int count;
    class Node
    {
        public int Value;
        public Node Next;

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public LinkedList() {
        first = null;
        count = 0;
    }

public int Get(int index)
{
    if (index < 0 || index >= count)
        return -1;

    var current = first;

    for (int i = 0; i < index; i++)
    {
        current = current.Next;
    }

    return current.Value;
}

    public void InsertHead(int val) {
        var temp = first;
        var newOne = new Node(val);
        newOne.Next = first;
        first = newOne;
        count++;
    }

    public void InsertTail(int val) {
        
        var newOne = new Node(val);

        if (first == null)
        {
            first = newOne;
        }
        else
        {
            var current = first;
            while (current.Next != null)
                current = current.Next;

            current.Next = newOne;
        }

        count++;
    }

public bool Remove(int index)
{
    if (index < 0 || index >= count)
        return false;

    var cur = first;
    for (int i = 0; i < index - 1; i++)
        cur = cur.Next;

    if (index == 0)
        first = first.Next;
    else
        cur.Next = cur.Next.Next;

    count--;
    return true;
}

    public List<int> GetValues() {
        var result = new List<int>();
     
        if(first == null){
            return new List<int>();
        }
        var current = first;
        while (true){
            result.Add(current.Value);
            if(current.Next != null){
            current = current.Next;
            }else{
                return result;
            }
        
        }
    }
}
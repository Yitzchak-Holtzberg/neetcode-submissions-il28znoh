public class Solution {
    public int CalPoints(string[] operations) {
        var myStack = new Stack<int>();
        foreach (var op in operations) {
            if (op == "+") {
                myStack.Push(myStack.ElementAt(0) + myStack.ElementAt(1));
            } else if (op == "D") {
                myStack.Push(myStack.ElementAt(0) * 2);
            } else if (op == "C") {
                myStack.Pop();
            }else{
                myStack.Push(int.Parse(op));
            }
        }
        return myStack.Sum();
    }
}
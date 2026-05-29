public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var toRemove = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };
        foreach (var t in s) {
            if (toRemove.ContainsKey(t)) {
                if (stack.Count == 0 || stack.Pop() != toRemove[t]) {
                    return false;
                }
            } else {
                stack.Push(t);
            }
        }
        return stack.Count == 0;
    }
}

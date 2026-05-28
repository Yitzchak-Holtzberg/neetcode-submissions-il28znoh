public class Solution {
    public int CalPoints(string[] operations) {
        var r = new List<int>(operations.Length);
        foreach (var op in operations) {
            switch (op[0]) {
                case '+': r.Add(r[^1] + r[^2]); break;
                case 'D': r.Add(r[^1] * 2); break;
                case 'C': r.RemoveAt(r.Count - 1); break;
                default:  r.Add(int.Parse(op)); break;
            }
        }
        int sum = 0;
        foreach (var x in r) sum += x;
        return sum;
    }
}
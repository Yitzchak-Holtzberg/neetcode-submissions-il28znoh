public class Solution {
    public int CalPoints(string[] operations) {
        var record = new List<int>(operations.Length);
        int sum = 0;
        foreach (var op in operations) {
            int val;
            switch (op[0]) {
                case '+':
                    val = record[^1] + record[^2];
                    record.Add(val);
                    sum += val;
                    break;
                case 'D':
                    val = record[^1] * 2;
                    record.Add(val);
                    sum += val;
                    break;
                case 'C':
                    sum -= record[^1];
                    record.RemoveAt(record.Count - 1);
                    break;
                default:
                    val = int.Parse(op);
                    record.Add(val);
                    sum += val;
                    break;
            }
        }
        return sum;
    }
}
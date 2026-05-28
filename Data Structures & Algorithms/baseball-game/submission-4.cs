public class Solution {
    public int CalPoints(string[] operations) {
        Span<int> stack = stackalloc int[operations.Length];
        int top = 0;
        int sum = 0;

        foreach (var op in operations) {
            int val;
            switch (op[0]) {
                case '+':
                    val = stack[top - 1] + stack[top - 2];
                    stack[top++] = val;
                    sum += val;
                    break;
                case 'D':
                    val = stack[top - 1] * 2;
                    stack[top++] = val;
                    sum += val;
                    break;
                case 'C':
                    sum -= stack[--top];
                    break;
                default:
                    val = ParseInt(op);
                    stack[top++] = val;
                    sum += val;
                    break;
            }
        }
        return sum;
    }

    private static int ParseInt(string s) {
        int i = 0, result = 0;
        bool neg = s[0] == '-';
        if (neg) i = 1;
        for (; i < s.Length; i++)
            result = result * 10 + (s[i] - '0');
        return neg ? -result : result;
    }
}
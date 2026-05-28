public class Solution {
    public int CalPoints(string[] operations) {
        int n = operations.Length;
        Span<int> stack = stackalloc int[n];
        ref int baseRef = ref System.Runtime.InteropServices.MemoryMarshal.GetReference(stack);
        int top = 0, sum = 0;

        for (int i = 0; i < n; i++) {
            string op = operations[i];
            int val;
            switch (op[0]) {
                case '+':
                    val = System.Runtime.CompilerServices.Unsafe.Add(ref baseRef, top - 1)
                        + System.Runtime.CompilerServices.Unsafe.Add(ref baseRef, top - 2);
                    System.Runtime.CompilerServices.Unsafe.Add(ref baseRef, top++) = val;
                    sum += val;
                    break;
                case 'D':
                    val = System.Runtime.CompilerServices.Unsafe.Add(ref baseRef, top - 1) * 2;
                    System.Runtime.CompilerServices.Unsafe.Add(ref baseRef, top++) = val;
                    sum += val;
                    break;
                case 'C':
                    sum -= System.Runtime.CompilerServices.Unsafe.Add(ref baseRef, --top);
                    break;
                default:
                    val = ParseInt(op);
                    System.Runtime.CompilerServices.Unsafe.Add(ref baseRef, top++) = val;
                    sum += val;
                    break;
            }
        }
        return sum;
    }

    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private static int ParseInt(string s) {
        int i = 0, result = 0;
        bool neg = s[0] == '-';
        if (neg) i = 1;
        for (int len = s.Length; i < len; i++)
            result = result * 10 + (s[i] - '0');
        return neg ? -result : result;
    }
}
// public class Pair {
//     public int Key;
//     public string Value;
// }

// Two parts to this:
//  1. Insertion sort is a nested array, outer array provides the value, inner walks until we find
//  where the value belongs.
//  2. In this case we also want to add each step to a list.
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        var result = new List<List<Pair>>();
        for (int i = 0; i < pairs.Count; i++) {
            for (int j = 0; j < i; j++) {
                if (pairs[i].Key < pairs[j].Key) {
                    var temp = pairs[i];
                    pairs.RemoveAt(i);
                    pairs.Insert(j, temp);
                    break;
                }
            }
            result.Add([..pairs]);
        }

        return result;
    }
}
public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        var weird = new Queue<int>();

        for (int i = 0; i < students.Length; i++) {
            weird.Enqueue(students[i]);
        }
        var counter = 0;
        var state = 0;
        while (state < sandwiches.Length && counter < weird.Count) {
            if (weird.Peek() == sandwiches[state]) {
                weird.Dequeue();
                state++;
                counter = 0;
            } else {
                weird.Enqueue(weird.Peek());
                weird.Dequeue();
                counter++;
            }
        }
        return counter;
    }
}

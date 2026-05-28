impl Solution {
    pub fn cal_points(operations: Vec<String>) -> i32 {
        let mut stack: Vec<i32> = Vec::with_capacity(operations.len());
        let mut sum: i32 = 0;

        for op in &operations {
            match op.as_bytes()[0] {
                b'+' => {
                    let n = stack.len();
                    let val = stack[n - 1] + stack[n - 2];
                    stack.push(val);
                    sum += val;
                }
                b'D' => {
                    let val = stack[stack.len() - 1] * 2;
                    stack.push(val);
                    sum += val;
                }
                b'C' => {
                    sum -= stack.pop().unwrap();
                }
                _ => {
                    let val: i32 = op.parse().unwrap();
                    stack.push(val);
                    sum += val;
                }
            }
        }
        sum
    }
}
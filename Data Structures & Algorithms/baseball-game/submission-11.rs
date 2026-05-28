impl Solution {
    pub fn cal_points(operations: Vec<String>) -> i32 {
        let mut stack: Vec<i32> = Vec::with_capacity(operations.len());
        let mut sum: i32 = 0;

        for op in &operations {
            let bytes = op.as_bytes();
            match bytes[0] {
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
                    let val = parse_int(bytes);
                    stack.push(val);
                    sum += val;
                }
            }
        }
        sum
    }
}

fn parse_int(bytes: &[u8]) -> i32 {
    let (neg, start) = if bytes[0] == b'-' { (true, 1) } else { (false, 0) };
    let mut result: i32 = 0;
    for &b in &bytes[start..] {
        result = result * 10 + (b - b'0') as i32;
    }
    if neg { -result } else { result }
}
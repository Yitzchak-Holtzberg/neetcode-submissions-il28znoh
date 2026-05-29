#[derive(Default)]
struct MinStack {
    stack: Vec<i32>,
    min: Vec<usize>,
}

impl MinStack {
    pub fn new() -> Self {
        Self::default()
    }

    pub fn push(&mut self, val: i32) {
        if self.min.is_empty() { self.min.push(0) } else {
            if val < self.stack[*self.min.last().unwrap()] {
                self.min.push(self.stack.len())
            }
        }
        self.stack.push(val);
    }

    pub fn pop(&mut self) {
        if *self.min.last().unwrap() == self.stack.len()-1 { self.min.pop(); }
        self.stack.pop();
    }

    pub fn top(&self) -> i32 {
        *self.stack.last().unwrap()
    }

    pub fn get_min(&self) -> i32 {
        self.stack[*self.min.last().unwrap()]
    }
}
#[cfg(test)]
mod tests {
    use crate::ListNode;

    #[test]
    fn add_two_numbers() {
        let expected = Some(Box::new(ListNode {
            val: 7,
            next: Some(Box::new(ListNode {
                val: 0,
                next: Some(Box::new(ListNode { val: 8, next: None })),
            })),
        }));

        let l1 = Some(Box::new(ListNode {
            val: 2,
            next: Some(Box::new(ListNode {
                val: 4,
                next: Some(Box::new(ListNode { val: 3, next: None })),
            })),
        }));

        let l2 = Some(Box::new(ListNode {
            val: 5,
            next: Some(Box::new(ListNode {
                val: 6,
                next: Some(Box::new(ListNode { val: 4, next: None })),
            })),
        }));

        let result = add_linked_lists(l1, l2);

        println!("{:?}", result);

        assert_eq!(result, expected);
    }

    fn add_linked_lists(
        mut l1: Option<Box<ListNode>>,
        mut l2: Option<Box<ListNode>>,
    ) -> Option<Box<ListNode>> {
        let mut head = None;
        let mut r = &mut head;
        let mut carry = 0;

        loop {
            let rest = match (&l1, &l2) {
                (Some(x), Some(y)) => {
                    let total = x.val + y.val + carry;
                    let rest = total % 10;
                    carry = total / 10;
                    rest
                }
                (None, Some(y)) => {
                    let total = y.val + carry;
                    let rest = total % 10;
                    carry = total / 10;
                    rest
                }
                (Some(x), None) => {
                    let total = x.val + carry;
                    let rest = total % 10;
                    carry = total / 10;
                    rest
                }
                (None, None) => {
                    if carry == 0 {
                        return head;
                    }
                    _ = r.insert(Box::new(ListNode::new(carry)));

                    return head;
                }
            };

            _ = r.insert(Box::new(ListNode::new(rest)));
            l1 = l1.and_then(|x| x.next);
            l2 = l2.and_then(|x| x.next);
            r = &mut r.as_mut().unwrap().next;
        }
    }
}

//Definition for singly-linked list.
#[derive(PartialEq, Eq, Clone, Debug)]
pub struct ListNode {
    pub val: i32,
    pub next: Option<Box<ListNode>>,
}

impl ListNode {
    #[inline]
    fn new(val: i32) -> Self {
        ListNode { next: None, val }
    }
}

fn main() {
    let n = 115;

    let result = fizz_buzz(n);

    for x in result {
        println!("{}", x);
    }
}

pub fn fizz_buzz(n: i32) -> Vec<String> {
    let mut map = Vec::new();
    map.push((3, "Fizz".to_owned()));
    map.push((5, "Buzz".to_owned()));

    let mut output = Vec::new();
    for x in 1..=n {
        output.push(check_num(&map, x));
    }

    output
}

pub fn check_num(map: &Vec<(i32, String)>, num: i32) -> String {
    let mut num_str = "".to_string();
    for x in map {
        if num % x.0 == 0 {
            num_str.push_str(&x.1);
            continue;
        }
    }

    if num_str == "" {
        num_str = num.to_string();
    }

    num_str
}

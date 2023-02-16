use libloading::{Library, Symbol};

fn main() {
    unsafe {
        let native_library = Library::new("/native-demo/native-c#.dll").unwrap();
        let print_message: Symbol<unsafe extern fn()> = native_library.get(b"print_message").unwrap();
        let add_numbers: Symbol<unsafe extern fn(i32, i32) -> i32> = native_library.get(b"add_numbers").unwrap();
        let subtract_numbers: Symbol<unsafe extern fn(i32, i32) -> i32> = native_library.get(b"subtract_numbers").unwrap();
        let multiply_numbers: Symbol<unsafe extern fn(f64, f64) -> f64> = native_library.get(b"multiply_numbers").unwrap();
        let divide_numbers: Symbol<unsafe extern fn(f64, f64) -> f64> = native_library.get(b"divide_numbers").unwrap();
        let populate_array: Symbol<unsafe extern fn(*mut f64, usize)> = native_library.get(b"populate_array").unwrap();

        let added = add_numbers(7, 2);
        let subtracted = subtract_numbers(7, 2);
        let multiplied = multiply_numbers(7.0, 2.0);
        let divided = divide_numbers(7.0, 2.0);

        let mut array: [f64; 5] = [0.0; 5];
        populate_array(array.as_mut_ptr(), array.len());

        print_message();
        println!("{}", added);
        println!("{}", subtracted);
        println!("{}", multiplied);
        println!("{}", divided);
        println!("{:?}", array);
    }
}
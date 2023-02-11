fn main() {
    unsafe {
        let native_library = libloading::Library::new("/Native-Demo/Native-C#.dll").unwrap();
        let add_numbers: libloading::Symbol<unsafe extern fn(u32, u32) -> u32> = native_library.get(b"add_numbers").unwrap();
        let subtract_numbers: libloading::Symbol<unsafe extern fn(u32, u32) -> u32> = native_library.get(b"subtract_numbers").unwrap();
        let multiply_numbers: libloading::Symbol<unsafe extern fn(f64, f64) -> f64> = native_library.get(b"multiply_numbers").unwrap();
        let divide_numbers: libloading::Symbol<unsafe extern fn(f64, f64) -> f64> = native_library.get(b"divide_numbers").unwrap();

        let added = add_numbers(7, 2);
        let subtracted = subtract_numbers(7, 2);
        let multiplied = multiply_numbers(7.0, 2.0);
        let divided = divide_numbers(7.0, 2.0);

        println!("{}", added);
        println!("{}", subtracted);
        println!("{}", multiplied);
        println!("{}", divided);
    }
}
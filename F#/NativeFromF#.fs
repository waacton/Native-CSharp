open System.Runtime.InteropServices

module NativeLibrary =
    [<DllImport("/native-demo/native-c#.dll")>]
    extern void print_message()

    [<DllImport("/native-demo/native-c#.dll")>]
    extern int add_numbers(int x, int y)

    [<DllImport("/native-demo/native-c#.dll")>]
    extern int subtract_numbers(int x, int y)

    [<DllImport("/native-demo/native-c#.dll")>]
    extern double multiply_numbers(double x, double y)

    [<DllImport("/native-demo/native-c#.dll")>]
    extern double divide_numbers(double x, double y)

    [<DllImport("/native-demo/native-c#.dll")>]
    extern void populate_array(double[] array, int arraySize)

let added = NativeLibrary.add_numbers(7, 2)
let subtracted = NativeLibrary.subtract_numbers(7, 2)
let multiplied = NativeLibrary.multiply_numbers(7, 2)
let divided = NativeLibrary.divide_numbers(7, 2)

let array = Array.zeroCreate 5
NativeLibrary.populate_array(array, array.Length)

NativeLibrary.print_message()
printfn "%i" added
printfn "%i" subtracted
printfn "%f" multiplied
printfn "%f" divided
printfn "%A" array
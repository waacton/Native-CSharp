using System.Runtime.InteropServices;

[DllImport("/native-demo/native-c#.dll")]
static extern void print_message();

[DllImport("/native-demo/native-c#.dll")]
static extern int add_numbers(int x, int y);

[DllImport("/native-demo/native-c#.dll")]
static extern int subtract_numbers(int x, int y);

[DllImport("/native-demo/native-c#.dll")]
static extern double multiply_numbers(double x, double y);

[DllImport("/native-demo/native-c#.dll")]
static extern double divide_numbers(double x, double y);

[DllImport("/native-demo/native-c#.dll")]
static extern void populate_array(double[] arrayPointer, int arraySize);

var added = add_numbers(7, 2);
var subtracted = subtract_numbers(7, 2);
var multiplied = multiply_numbers(7, 2);
var divided = divide_numbers(7, 2);

var array = new double[5];
populate_array(array, array.Length);

print_message();
Console.WriteLine(added);
Console.WriteLine(subtracted);
Console.WriteLine(multiplied);
Console.WriteLine(divided);
Console.WriteLine(string.Join(", ", array));

/*
 * this code is a more "direct" usage of the 'populate_array()' native function, which actually expects a pointer
 * however, getting the pointer is more work than necessary, when we can simply pass the array
 * which the native function will consume as a pointer

[DllImport("/native-demo/native-c#.dll")]
static extern unsafe void populate_array(double* arrayPointer, double arraySize);

var array = new double[5];
unsafe
{
    fixed (double* pointer = array)
    {
        populate_array(pointer, array.Length);
    }
}

*/
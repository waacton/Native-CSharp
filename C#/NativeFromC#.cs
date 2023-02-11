using System.Runtime.InteropServices;

[DllImport("/Native-Demo/Native-C#.dll")]
static extern int add_numbers(int x, int y);

[DllImport("/Native-Demo/Native-C#.dll")]
static extern int subtract_numbers(int x, int y);

[DllImport("/Native-Demo/Native-C#.dll")]
static extern double multiply_numbers(double x, double y);

[DllImport("/Native-Demo/Native-C#.dll")]
static extern double divide_numbers(double x, double y);

var added = add_numbers(7, 2);
var subtracted = subtract_numbers(7, 2);
var multiplied = multiply_numbers(7, 2);
var divided = divide_numbers(7, 2);

Console.WriteLine(added);
Console.WriteLine(subtracted);
Console.WriteLine(multiplied);
Console.WriteLine(divided);
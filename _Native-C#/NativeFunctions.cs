using System.Runtime.InteropServices;

public class Native
{
    [UnmanagedCallersOnly(EntryPoint = "add_numbers")]
    public static int Add(int x, int y) => x + y;

    [UnmanagedCallersOnly(EntryPoint = "subtract_numbers")]
    public static int Subtract(int x, int y) => x - y;

    [UnmanagedCallersOnly(EntryPoint = "multiply_numbers")]
    public static double Multiply(double x, double y) => x * y;

    [UnmanagedCallersOnly(EntryPoint = "divide_numbers")]
    public static double Divide(double x, double y) => x / y;
}
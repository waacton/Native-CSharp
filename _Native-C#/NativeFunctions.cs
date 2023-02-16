using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Native
{
    [UnmanagedCallersOnly(EntryPoint = "print_message")]
    public static void PrintMessage() => Console.WriteLine("Hello from native code written in C#!");

    [UnmanagedCallersOnly(EntryPoint = "add_numbers")]
    public static int Add(int x, int y) => x + y;

    [UnmanagedCallersOnly(EntryPoint = "subtract_numbers")]
    public static int Subtract(int x, int y) => x - y;

    [UnmanagedCallersOnly(EntryPoint = "multiply_numbers")]
    public static double Multiply(double x, double y) => x * y;

    [UnmanagedCallersOnly(EntryPoint = "divide_numbers")]
    public static double Divide(double x, double y) => x / y;

    [UnmanagedCallersOnly(EntryPoint = "populate_array")]
    public static unsafe void PopulateArray(double* arrayPointer, int arraySize)
    {
        for (int i = 0; i < arraySize; i++)
        {
            arrayPointer[i] = (i * 2) + 0.5;
        }
    }
}
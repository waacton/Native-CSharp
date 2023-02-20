In the C# example of `populate_array()`:
* `native-c#.dll` expects `double*`
* `NativeFromC#.cs` passes `double[]`

It is very convenient that the native function consumes the `double[]` as a `double*`,
as it means we don't need to directly interact with unsafe code to obtain the pointer.

For completeness, here is an alternative approach to populating the array that
explicitly uses the pointer.

```c#
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
```
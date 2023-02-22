Imports System.Runtime.InteropServices

Module NativeFromVisualBasic
    <DllImport("/native-demo/native-c#.dll")> _
    Sub print_message()
    End Sub
    
    <DllImport("/native-demo/native-c#.dll")> _
    Function add_numbers(x As Integer, y As Integer) As Integer
    End Function
    
    <DllImport("/native-demo/native-c#.dll")> _
    Function subtract_numbers(x As Integer, y As Integer) As Integer
    End Function
    
    <DllImport("/native-demo/native-c#.dll")> _
    Function multiply_numbers(x As Double, y As Double) As Double
    End Function
    
    <DllImport("/native-demo/native-c#.dll")> _
    Function divide_numbers(x As Double, y As Double) As Double
    End Function
    
    <DllImport("/native-demo/native-c#.dll")> _
    Sub populate_array(array As Double(), arraySize As Integer)
    End Sub
    
    Sub Main()
        Dim added = add_numbers(7, 2)
        Dim subtracted = subtract_numbers(7, 2)
        Dim multiplied = multiply_numbers(7, 2)
        Dim divided = divide_numbers(7, 2)
        
        Dim array(5) As Double
        populate_array(array, array.Length)
        
        print_message()
        Console.WriteLine(added)
        Console.WriteLine(subtracted)
        Console.WriteLine(multiplied)
        Console.WriteLine(divided)
        Console.WriteLine(String.Join(", ", array))
    End Sub
End Module

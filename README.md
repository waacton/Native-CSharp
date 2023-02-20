# Call C# library from any language
This repo demonstrates how to use [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)'s [Native AOT](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/) feature to build a native DLL that can be called from other languages, such as Java and Python.

## 1. Enable native AOT publishing
In the `.csproj` file add `<PublishAot>true</PublishAot>` ([see example](/_Native-C%23/Native-C%23.csproj))

## 2. Expose native functions
Associate the C# native functions with the `[UnmanagedCallersOnly]` attribute ([see example](/_Native-C%23/NativeFunctions.cs))

## 3. Publish to a native DLL
For these examples the native DLL is published to `/native-demo/native-c#.dll`:
```shell
   dotnet publish ./_native-c#/ -r win-x64 -o /native-demo
```

## 4. Use the native DLL in any language
Load the library at runtime and call the native functions. See examples in:
- [C#](/C%23/NativeFromC%23.cs)
- [C++](/C%2B%2B/NativeFromC%2B%2B.cpp)
- [F#](/F%23/NativeFromF%23.fs)
- [Go](/Go/NativeFromGo.go)
- [Java](/Java/NativeFromJava.java)
- [JavaScript](/JavaScript/NativeFromJavaScript.js)
- [Python](/Python/NativeFromPython.py)
- [Ruby](/Ruby/NativeFromRuby.rb)
- [Rust](/Rust/NativeFromRust.rs)

All examples showcase using native functions that:
- prints a message to the console,
- returns a 32-bit integer (`7 + 2`, `7 - 2`),
- returns a 64-bit double (`7 * 2`, `7 / 2`),
- modifies an array of 64-bit doubles (`array[i] = (i * 2) + 0.5`)

The output should look something like:
```
Hello from native code written in C#!
9
5
14
3.5
[0.5, 2.5, 4.5, 6.5, 8.5]
```
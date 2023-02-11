# Call C# DLL from any language

This repo demonstrates how to use [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)'s [Native AOT](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/) feature to build a native DLL that can be called from other languages, such as Java and Python.

1. Make sure the native C# project has `<PublishAot>true</PublishAot>` and exposes functions with the `[UnmanagedCallersOnly]` attribute.
1. Publish the project to generate native code:
   ```shell
   dotnet publish .\_Native-C#\ -r win-x64 -o /Native-Demo`
   ```
1. Dynamically the DLL in a language of your choice and call the functions (see example code)

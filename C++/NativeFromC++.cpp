#include <windows.h>
#include <stdio.h>
#include <iostream>

int main()
{
    auto nativeLibrary = LoadLibrary(TEXT("/Native-Demo/Native-C#.dll"));
    auto addNumbersProcAddress = (int (*)(int, int))GetProcAddress(nativeLibrary, "add_numbers");
    auto subtractNumbersProcAddress = (int (*)(int, int))GetProcAddress(nativeLibrary, "subtract_numbers");
    auto multiplyNumbersProcAddress = (double (*)(double, double))GetProcAddress(nativeLibrary, "multiply_numbers");
    auto divideNumbersProcAddress = (double (*)(double, double))GetProcAddress(nativeLibrary, "divide_numbers");

    auto added = addNumbersProcAddress(7, 2);
    auto subtracted = subtractNumbersProcAddress(7, 2);
    auto multiplied = multiplyNumbersProcAddress(7, 2);
    auto divided = divideNumbersProcAddress(7, 2);

    std::cout << added << std::endl;
    std::cout << subtracted << std::endl;
    std::cout << multiplied << std::endl;
    std::cout << divided << std::endl;

    FreeLibrary(nativeLibrary);
    return 0;
}
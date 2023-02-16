#include <windows.h>
#include <stdio.h>
#include <iostream>

int main()
{
    auto nativeLibrary = LoadLibrary(TEXT("/native-demo/native-c#.dll"));
    auto print_message = GetProcAddress(nativeLibrary, "print_message");
    auto add_numbers = (int (*)(int, int))GetProcAddress(nativeLibrary, "add_numbers");
    auto subtract_numbers = (int (*)(int, int))GetProcAddress(nativeLibrary, "subtract_numbers");
    auto multiply_numbers = (double (*)(double, double))GetProcAddress(nativeLibrary, "multiply_numbers");
    auto divide_numbers = (double (*)(double, double))GetProcAddress(nativeLibrary, "divide_numbers");
    auto populate_array = (void (*)(double[], int))GetProcAddress(nativeLibrary, "populate_array");

    auto added = add_numbers(7, 2);
    auto subtracted = subtract_numbers(7, 2);
    auto multiplied = multiply_numbers(7, 2);
    auto divided = divide_numbers(7, 2);

    auto array = new double[5];
    populate_array(array, sizeof(array));

    print_message();
    std::cout << added << std::endl;
    std::cout << subtracted << std::endl;
    std::cout << multiplied << std::endl;
    std::cout << divided << std::endl;
    for (int i = 0; i < 5; i++)
    {
        std::cout << array[i] << " ";
    }

    FreeLibrary(nativeLibrary);
    return 0;
}
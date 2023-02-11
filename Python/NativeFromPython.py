from ctypes import *

nativeLibrary = cdll.LoadLibrary("/Native-Demo/Native-C#.dll")
# argtypes & restypes assumed to be int
nativeLibrary.multiply_numbers.argtypes = [c_double, c_double]
nativeLibrary.multiply_numbers.restype = c_double
nativeLibrary.divide_numbers.argtypes = [c_double, c_double]
nativeLibrary.divide_numbers.restype = c_double

added = nativeLibrary.add_numbers(7, 2)
subtracted = nativeLibrary.subtract_numbers(7, 2)
multiplied = nativeLibrary.multiply_numbers(7, 2)
divided = nativeLibrary.divide_numbers(7, 2)

print(added)
print(subtracted)
print(multiplied)
print(divided)
from ctypes import *

nativeLibrary = cdll.LoadLibrary("/native-demo/native-c#.dll")
# argtypes & restypes assumed to be int
nativeLibrary.multiply_numbers.argtypes = [c_double, c_double]
nativeLibrary.multiply_numbers.restype = c_double
nativeLibrary.divide_numbers.argtypes = [c_double, c_double]
nativeLibrary.divide_numbers.restype = c_double
nativeLibrary.populate_array.argtypes = [POINTER(c_double), c_int]

added = nativeLibrary.add_numbers(7, 2)
subtracted = nativeLibrary.subtract_numbers(7, 2)
multiplied = nativeLibrary.multiply_numbers(7, 2)
divided = nativeLibrary.divide_numbers(7, 2)

array = (c_double * 5)(*[])
nativeLibrary.populate_array(array, len(array))

nativeLibrary.print_message()
print(added)
print(subtracted)
print(multiplied)
print(divided)
print(list(array))

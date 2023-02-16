require 'fiddle'

nativeLibrary = Fiddle.dlopen('/native-demo/native-c#.dll')
print_message = Fiddle::Function.new(nativeLibrary['print_message'], [], Fiddle::TYPE_VOID)
add_numbers = Fiddle::Function.new(nativeLibrary['add_numbers'], [Fiddle::TYPE_INT, Fiddle::TYPE_INT], Fiddle::TYPE_INT)
subtract_numbers = Fiddle::Function.new(nativeLibrary['subtract_numbers'], [Fiddle::TYPE_INT, Fiddle::TYPE_INT], Fiddle::TYPE_INT)
multiply_numbers = Fiddle::Function.new(nativeLibrary['multiply_numbers'], [Fiddle::TYPE_DOUBLE, Fiddle::TYPE_DOUBLE], Fiddle::TYPE_DOUBLE)
divide_numbers = Fiddle::Function.new(nativeLibrary['divide_numbers'], [Fiddle::TYPE_DOUBLE, Fiddle::TYPE_DOUBLE], Fiddle::TYPE_DOUBLE)
populate_array = Fiddle::Function.new(nativeLibrary['populate_array'], [Fiddle::TYPE_VOIDP, Fiddle::TYPE_INT], Fiddle::TYPE_VOID)

added = add_numbers.call(7, 2)
subtracted = subtract_numbers.call(7, 2)
multiplied = multiply_numbers.call(7, 2)
divided = divide_numbers.call(7, 2)

array = Array.new(5, 0.0)
pointer = Fiddle::Pointer[array.pack('d*')]
populate_array.call(pointer, array.size)
array = pointer.to_s(array.size * Fiddle::SIZEOF_DOUBLE).unpack('d*')

print_message.call()
p added
p subtracted
p multiplied
p divided
p array
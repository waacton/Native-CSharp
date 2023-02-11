require 'fiddle'

nativeLibrary = Fiddle.dlopen('/Native-Demo/Native-C#.dll')
add_numbers = Fiddle::Function.new(nativeLibrary['add_numbers'], [Fiddle::TYPE_INT, Fiddle::TYPE_INT], Fiddle::TYPE_INT)
subtract_numbers = Fiddle::Function.new(nativeLibrary['subtract_numbers'], [Fiddle::TYPE_INT, Fiddle::TYPE_INT], Fiddle::TYPE_INT)
multiply_numbers = Fiddle::Function.new(nativeLibrary['multiply_numbers'], [Fiddle::TYPE_DOUBLE, Fiddle::TYPE_DOUBLE], Fiddle::TYPE_DOUBLE)
divide_numbers = Fiddle::Function.new(nativeLibrary['divide_numbers'], [Fiddle::TYPE_DOUBLE, Fiddle::TYPE_DOUBLE], Fiddle::TYPE_DOUBLE)

added = add_numbers.call(7, 2)
subtracted = subtract_numbers.call(7, 2)
multiplied = multiply_numbers.call(7, 2)
divided = divide_numbers.call(7, 2)

puts added
puts subtracted
puts multiplied
puts divided
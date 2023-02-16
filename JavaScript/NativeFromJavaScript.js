const ffi = require("ffi-napi");
const ArrayType = require("ref-array-napi");

const DoubleArray = ArrayType("double");

const nativeLibrary = ffi.Library("/native-demo/native-c#.dll", {
  print_message: ["void", []],
  add_numbers: ["int", ["int", "int"]],
  subtract_numbers: ["int", ["int", "int"]],
  multiply_numbers: ["double", ["double", "double"]],
  divide_numbers: ["double", ["double", "double"]],
  populate_array: ["void", [DoubleArray, "int"]],
});

const added = nativeLibrary.add_numbers(7, 2);
const subtracted = nativeLibrary.subtract_numbers(7, 2);
const multiplied = nativeLibrary.multiply_numbers(7, 2);
const divided = nativeLibrary.divide_numbers(7, 2);

const array = new DoubleArray(5);
nativeLibrary.populate_array(array, array.length);

nativeLibrary.print_message();
console.log(added);
console.log(subtracted);
console.log(multiplied);
console.log(divided);
console.log(JSON.stringify(array));
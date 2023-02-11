const ffi = require("ffi-napi");

const nativeLibrary = ffi.Library("/Native-Demo/Native-C#.dll", {
  add_numbers: ["int", ["int", "int"]],
  subtract_numbers: ["int", ["int", "int"]],
  multiply_numbers: ["double", ["double", "double"]],
  divide_numbers: ["double", ["double", "double"]],
});

const added = nativeLibrary.add_numbers(7, 2);
const subtracted = nativeLibrary.subtract_numbers(7, 2);
const multiplied = nativeLibrary.multiply_numbers(7, 2);
const divided = nativeLibrary.divide_numbers(7, 2);

console.log(added);
console.log(subtracted);
console.log(multiplied);
console.log(divided);

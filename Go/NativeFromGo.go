package main

import (
	"fmt"
	"math"
	"syscall"
)

var (
	nativeLibrary, _    = syscall.LoadLibrary("/Native-Demo/Native-C#.dll")
	add_numbers, _      = syscall.GetProcAddress(nativeLibrary, "add_numbers")
	subtract_numbers, _ = syscall.GetProcAddress(nativeLibrary, "subtract_numbers")
	multiply_numbers, _ = syscall.GetProcAddress(nativeLibrary, "multiply_numbers")
	divide_numbers, _   = syscall.GetProcAddress(nativeLibrary, "divide_numbers")

	added, _, _      = syscall.SyscallN(uintptr(add_numbers), 7, 2)
	subtracted, _, _ = syscall.SyscallN(uintptr(subtract_numbers), 7, 2)
	_, multiplied, _ = syscall.SyscallN(uintptr(multiply_numbers), uintptr(math.Float64bits(7)), uintptr(math.Float64bits(2)))
	_, divided, _    = syscall.SyscallN(uintptr(divide_numbers), uintptr(math.Float64bits(7)), uintptr(math.Float64bits(2)))
)

func main() {
	fmt.Println(added)
	fmt.Println(subtracted)
	fmt.Println(math.Float64frombits(uint64(multiplied)))
	fmt.Println(math.Float64frombits(uint64(divided)))
}

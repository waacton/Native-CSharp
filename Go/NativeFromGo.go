package main

import (
	"fmt"
	"math"
	"syscall"
	"unsafe"
)

var (
	nativeLibrary, _    = syscall.LoadLibrary("/native-demo/native-c#.dll")
	print_message, _    = syscall.GetProcAddress(nativeLibrary, "print_message")
	add_numbers, _      = syscall.GetProcAddress(nativeLibrary, "add_numbers")
	subtract_numbers, _ = syscall.GetProcAddress(nativeLibrary, "subtract_numbers")
	multiply_numbers, _ = syscall.GetProcAddress(nativeLibrary, "multiply_numbers")
	divide_numbers, _   = syscall.GetProcAddress(nativeLibrary, "divide_numbers")
	populate_array, _   = syscall.GetProcAddress(nativeLibrary, "populate_array")

	// floating point returned in r2 (https://tip.golang.org/src/syscall/dll_windows.go line 158)
	added, _, _      = syscall.SyscallN(add_numbers, 7, 2)
	subtracted, _, _ = syscall.SyscallN(subtract_numbers, 7, 2)
	_, multiplied, _ = syscall.SyscallN(multiply_numbers, uintptr(math.Float64bits(7)), uintptr(math.Float64bits(2)))
	_, divided, _    = syscall.SyscallN(divide_numbers, uintptr(math.Float64bits(7)), uintptr(math.Float64bits(2)))

	array   [5]float64
	pointer = unsafe.Pointer(&array[0])
)

func main() {
	defer syscall.FreeLibrary(nativeLibrary)

	syscall.SyscallN(print_message)
	fmt.Println(added)
	fmt.Println(subtracted)
	fmt.Println(math.Float64frombits(uint64(multiplied)))
	fmt.Println(math.Float64frombits(uint64(divided)))

	syscall.SyscallN(populate_array, uintptr(pointer), uintptr(len(array)))
	fmt.Println(array)
}

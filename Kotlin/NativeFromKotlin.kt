import com.sun.jna.Library
import com.sun.jna.Native

interface NativeLibrary : Library {
    companion object {
        val INSTANCE = Native.load("/native-demo/native-c#.dll", NativeLibrary::class.java) as NativeLibrary
    }

    fun print_message()
    fun add_numbers(x: Int, y: Int): Int
    fun subtract_numbers(x: Int, y: Int): Int
    fun multiply_numbers(x: Double, y: Double): Double
    fun divide_numbers(x: Double, y: Double): Double
    fun populate_array(array: DoubleArray, arraySize: Int)
}

fun main() {
    val added = NativeLibrary.INSTANCE.add_numbers(7, 2)
    val subtracted = NativeLibrary.INSTANCE.subtract_numbers(7, 2)
    val multiplied: Double = NativeLibrary.INSTANCE.multiply_numbers(7.0, 2.0)
    val divided: Double = NativeLibrary.INSTANCE.divide_numbers(7.0, 2.0)

    val array = DoubleArray(5)
    NativeLibrary.INSTANCE.populate_array(array, array.size)

    NativeLibrary.INSTANCE.print_message()
    println(added)
    println(subtracted)
    println(multiplied)
    println(divided)
    println(array.contentToString())
}
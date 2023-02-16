import com.sun.jna.Library;
import com.sun.jna.Native;

import java.util.Arrays;

public class NativeFromJava {

    public interface NativeLibrary extends Library {
        NativeLibrary INSTANCE = Native.load("/native-demo/native-c#.dll", NativeLibrary.class);
        void print_message();
        int add_numbers(int x, int y);
        int subtract_numbers(int x, int y);
        double multiply_numbers(double x, double y);
        double divide_numbers(double x, double y);
        void populate_array(double[] array, int arraySize);
    }

    public static void main(String[] args) {
        int added = NativeLibrary.INSTANCE.add_numbers(7, 2);
        int subtracted = NativeLibrary.INSTANCE.subtract_numbers(7, 2);
        double multiplied = NativeLibrary.INSTANCE.multiply_numbers(7, 2);
        double divided = NativeLibrary.INSTANCE.divide_numbers(7, 2);

        double[] array = new double[5];
        NativeLibrary.INSTANCE.populate_array(array, array.length);

        NativeLibrary.INSTANCE.print_message();
        System.out.println(added);
        System.out.println(subtracted);
        System.out.println(multiplied);
        System.out.println(divided);
        System.out.println(Arrays.toString(array));
    }
}

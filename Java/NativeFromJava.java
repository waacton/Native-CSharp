import com.sun.jna.Library;
import com.sun.jna.Native;

public class NativeFromJava {

    public interface NativeLibrary extends Library {
        NativeLibrary INSTANCE = Native.load("/Native-Demo/Native-C#.dll", NativeLibrary.class);
        int add_numbers(int x, int y);
        int subtract_numbers(int x, int y);
        double multiply_numbers(double x, double y);
        double divide_numbers(double x, double y);
    }

    public static void main(String[] args) {
        int added = NativeLibrary.INSTANCE.add_numbers(7, 2);
        int subtracted = NativeLibrary.INSTANCE.subtract_numbers(7, 2);
        double multiplied = NativeLibrary.INSTANCE.multiply_numbers(7, 2);
        double divided = NativeLibrary.INSTANCE.divide_numbers(7, 2);

        System.out.println(added);
        System.out.println(subtracted);
        System.out.println(multiplied);
        System.out.println(divided);
    }
}

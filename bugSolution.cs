public class MyClass {
    public double MyMethod(int a, int b) {
        if (b == 0) {
            throw new DivideByZeroException(); //Explicitly Handle Division by zero
        }
        return (double)a / b; // Cast to double to preserve fractional part
    }
}
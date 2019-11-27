import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
        String output="";
        if (n%2 == 1) {
            output = "Weird";
        }
        
        else {
            if (n > 20) {
                output = "Not Weird";
            }
            else {
                if (n >= 6) {
                    output = "Weird";
                }
                else {
                    output = "Not Weird";
                }
            }
        }
        
        System.out.print(output);
        
        scanner.close();
    }
}
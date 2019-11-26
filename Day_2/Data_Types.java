import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
	
    public static void main(String[] args) {
        int i = 4;
        double d = 4.0;
        String s = "HackerRank ";
		
        Scanner scan = new Scanner(System.in);
   
        /* Declare second integer, double, and String variables. */
        int i_new; 
        double d_new; 
        String s_new;  

        /* Read and save an integer, double, and String to your variables.*/
        i_new = scan.nextInt();
        d_new = scan.nextDouble();
        scan.nextLine();
        s_new = scan.nextLine();
        // Note: If you have trouble reading the entire String, please go back and review the Tutorial closely.
        
        /* Print the sum of both integer variables on a new line. */
        System.out.println(i + i_new);

        /* Print the sum of the double variables on a new line. */
		System.out.println(d + d_new);
        
        /* Concatenate and print the String variables on a new line; 
        	the 's' variable above should be printed first. */
        System.out.println(s + s_new);
        scan.close();
    }
}
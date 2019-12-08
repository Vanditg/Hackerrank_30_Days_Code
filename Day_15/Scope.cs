using System;
using System.Linq;

class Difference {
    int[] elements;
    public int maximumDifference;

public Difference (int [] elements) {
    this.elements = elements;
}

public void computeDifference() {
        int maximum = 0;
        int i, j, absolute;
        for (i = 0; i < elements.length; i++) {
            for (j = 0; j < elements.length; j++) {
                absolute = Math.abs(elements[i] - elements[j]);
                if (absolute > maximum) {
                    maximum = absolute; 
                }
            }
        }
        maximumDifference = maximum;
    }

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
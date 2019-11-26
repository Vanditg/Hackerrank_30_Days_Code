using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int i_new;
        double d_new;
        string s_new;

        i_new = int.Parse(Console.ReadLine());
        d_new = double.Parse(Console.ReadLine());
        s_new = Console.ReadLine();

        Console.WriteLine(i + i_new);
        Console.WriteLine(String.Format("{0:0.0}", d + d_new));
        Console.Write(s + s_new);        

    }
}
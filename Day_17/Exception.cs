using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        try {
            int strToInt = Int32.Parse(S);
            Console.WriteLine(strToInt);
        } catch(Exception e) {
            Console.WriteLine("Bad String");
        }
    }
}


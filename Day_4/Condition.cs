using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        string output = "";
        
        if(N%2 == 1) {
            output = "Weird";
        }

        else {
            if(N > 20) {
                output = "Not Weird";
            } 
            else {
                if ( N >= 6) {
                    output = "Weird";
                } 
                else {
                    output = "Not Weird";
                }
            }
        }
        Console.WriteLine(output);
    }
}

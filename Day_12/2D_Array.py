#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    array = []

    for _ in range(6):
        array.append(list(map(int, input().rstrip().split())))
    
    maximumSum = -9 * 9;
    sum = 0;
    for i in range(6):
        for j in range(6):
            if (j + 2 < 6 and i + 2 < 6): 
                sum = array[i][j] + array[i][j + 1] + array[i][j + 2] + array[i + 1][j + 1] + array[i + 2][j] + array[i + 2][j + 1] + array[i + 2][j + 2]
                
            if (sum > maximumSum):
                maximumSum = sum
        
    print(maximumSum)
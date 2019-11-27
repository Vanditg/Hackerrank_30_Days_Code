#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    N = int(input())
    output = ''
    if (N%2 == 1):
        output = 'Weird';
    else:
        if (N > 20):
            output = 'Not Weird';
        else:
            if(N >= 6):
                output = 'Weird';
            else:
                output = 'Not Weird';
    print(output)
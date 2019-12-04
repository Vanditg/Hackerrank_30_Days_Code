#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    n = int(input())

    plus = 0
    output = 0
    while n > 0:
        if n%2 == 1: 
            plus += 1
            if plus > output:
                output = plus
        else:
            plus = 0
        n //= 2
    print(output)
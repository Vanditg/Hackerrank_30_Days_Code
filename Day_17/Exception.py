#!/bin/python3

import sys


S = input().strip()

try: 
    strToInt = int(S)
    print(strToInt)
except: 
    print("Bad String")
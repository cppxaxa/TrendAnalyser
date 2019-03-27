from datetime import date
from nsepy import get_history

import sys

print("Hello")

"""
sbin = get_history(symbol='SBIN',
                   start=date(2015,1,1),
                   end=date(2015,1,10));

sbin.to_csv('example.csv', index=True, header=True, sep=',')

print(sbin.index);
#print(sbin.values);
"""

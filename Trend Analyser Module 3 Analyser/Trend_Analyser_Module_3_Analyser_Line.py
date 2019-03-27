import pandas as pd
import pandas_datareader.data as web
import datetime
from matplotlib.dates import date2num
from matplotlib.finance import candlestick_ohlc

import sys

directory = "D:\\Libraries\\Documents\\Visual Studio 2013\\Projects\\Trend Analyser\\Storage"
filename = "SBIN_2017_8_18_2017_7_19"

if(len(sys.argv) < 3):
    print("python program.py <directory> <filename>")
    exit()

directory = sys.argv[1]
filename = sys.argv[2]

#df = pd.read_csv(directory + "\\" + filename + ".csv", parse_dates=True, index_col=0)

stock = pd.read_csv(directory + "\\" + filename + ".csv", parse_dates=True, index_col=['Date'])

#print(stock.head())

#type(apple)

import matplotlib.pyplot as plt


pd.concat([stock.Close, stock.High, stock.Low, stock.Open],axis=1).plot(figsize=(9,5),grid=True)

figManager = plt.get_current_fig_manager()
figManager.window.showMaximized()

plt.plot()
plt.show()

"""
import pylab

pylab.rcParams['figure.figsize'] = (15, 7)   # Change the size of plots

stock["Close"].plot(grid = True)

pd.tseries.plotting.pylab.show()
"""
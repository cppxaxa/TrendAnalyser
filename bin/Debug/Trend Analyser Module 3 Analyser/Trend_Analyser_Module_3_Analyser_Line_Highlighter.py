"""

No Highlighter option available

"""


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
import pylab
import matplotlib.dates as mdates

pylab.rcParams['figure.figsize'] = (15, 7)   # Change the size of plots

stock["Close"].plot(grid = True)

figManager = plt.get_current_fig_manager()
figManager.window.showMaximized()

#fig, ax = plt.subplots()
#ax.axvspan(*mdates.datestr2num(['01/15/2015', '01/15/2016']), color='yellow', alpha=0.4)
#ax1.axvspan(*mdates.datestr2num([sdate, edate]), color='yellow', alpha=0.4)
#fig.autofmt_xdate()
#plt.axvspan(3, 6, color='red', alpha=0.5)

pd.tseries.plotting.pylab.show()


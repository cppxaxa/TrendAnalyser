import matplotlib
import matplotlib.pyplot as plt
from matplotlib import style
from matplotlib.finance import candlestick_ohlc
import matplotlib.dates as mdates
import datetime as dt
import pandas as pd
import pandas_datareader.data as web
import sys

style.use('ggplot')

#df = pd.read_csv('SBIN_2017_8_18_2017_7_19.csv', parse_dates=True, index_col=0)
directory = "D:\\Libraries\\Documents\\Visual Studio 2013\\Projects\\Trend Analyser\\Storage"
filename = "SBIN_2017_8_18_2017_7_19"

if(len(sys.argv) < 3):
    print("python program.py <directory> <filename>")
    exit()

directory = sys.argv[1]
filename = sys.argv[2]

df = pd.read_csv(directory + "\\" + filename + ".csv", parse_dates=True, index_col=0)
length = df.shape[0]

if(length < 25):
    resampling = '2D'
    width = 1
elif(length > 4000):
    resampling = '60D'
    width = 4
elif(length > 1500):
    resampling = '24D'
    width = 4
elif(length > 800):
    resampling = '12D'
    width = 4
elif(length > 100):
    resampling = '7D'
    width = 4
else:
    resampling = '2D'
    width = 1

df_ohlc = df['Close'].resample(resampling).ohlc()
df_volume = df['Volume'].resample(resampling).sum()
df_ohlc.reset_index(inplace=True)

df_ohlc['Date'] = df_ohlc['Date'].map(mdates.date2num)

ax1 = plt.subplot2grid((6,1),(0,0),rowspan=5,colspan=1)
ax2 = plt.subplot2grid((6,1),(5,0),rowspan=1,colspan=1,sharex=ax1)

ax1.xaxis_date()
candlestick_ohlc(ax1,df_ohlc.values,width=width,colorup='g')
ax2.fill_between(df_volume.index.map(mdates.date2num),df_volume.values,0)

figManager = plt.get_current_fig_manager()
figManager.window.showMaximized()

plt.show()


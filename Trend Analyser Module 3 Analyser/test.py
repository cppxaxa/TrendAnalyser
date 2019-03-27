import pandas as pd
import matplotlib.pyplot as plt
import numpy as np

import sys

"""

def BBANDS(data,ndays):
    MA=data.Close.rolling(n).mean()
    SD=data.Close.rolling(n).std()
    data['MA']=MA
    data['UBB']=MA+(2*SD)
    data['LBB']=MA-(2*SD)
    return data

directory = "D:\\Libraries\\Documents\\Visual Studio 2013\\Projects\\Trend Analyser\\Storage"
filename = "SBIN_2017_8_24_2014_12_1"

if(len(sys.argv) < 3):
    print("python prog.py <directory> <filename>")
    exit()

directory = sys.argv[1]
filename = sys.argv[2]

#data=pdr.get_data_yahoo('^NSEI',start='2016-07-01',end='2017-08-01')
#Open High Low Close Adj Close Volume
#data=pd.DataFrame(data)

mydata = pd.read_csv(directory + "\\" + filename + ".csv", parse_dates=True, index_col=0)
#mydata=pd.DataFrame(mydata)

#print(data.loc['2017-08-24']['Symbol'])
#print(data.columns)
#print("My Data")
mydata.drop('Symbol', axis=1, inplace=True)
mydata.drop('Series', axis=1, inplace=True)
mydata.drop('Prev Close', axis=1, inplace=True)
mydata.drop('VWAP', axis=1, inplace=True)
mydata.drop('Turnover', axis=1, inplace=True)
mydata.drop('Trades', axis=1, inplace=True)
mydata.drop('Deliverable Volume', axis=1, inplace=True)
mydata.drop('%Deliverble', axis=1, inplace=True)
newcols = {
    'Last' : 'Adj Close'
}
mydata.rename(columns=newcols, inplace=True)

data = mydata

n=20
NBB=BBANDS(data,n)

pd.concat([NBB.MA,NBB.Close,NBB.UBB,NBB.LBB],axis=1).plot(figsize=(9,5),grid=True)

figManager = plt.get_current_fig_manager()
figManager.window.showMaximized()

plt.plot()
plt.show()

"""
"""
import matplotlib.pyplot as plt
from scipy.interpolate import InterpolatedUnivariateSpline
x = np.linspace(-3, 3, 50)
y = np.exp(-x**2) + 0.1 * np.random.randn(50)
spl = InterpolatedUnivariateSpline(x, y)
plt.plot(x, y, 'ro', ms=5)
xs = np.linspace(-3, 3, 1000)
plt.plot(xs, spl(xs), 'g', lw=3, alpha=0.7)
plt.show()
"""

"""
import matplotlib.pyplot as plt
from scipy.interpolate import Rbf, InterpolatedUnivariateSpline

x = np.linspace(-3, 3, 50)
y = np.exp(-x**2) + 0.1 * np.random.randn(50)
spl = InterpolatedUnivariateSpline(x, y)
plt.plot(x, y, 'ro', ms=5)

xs = np.linspace(-3, 3.1, 1000)
plt.plot(xs, spl(xs), 'g', lw=3, alpha=0.7)

rbf = Rbf(x, y)
fi = rbf(xs)
plt.plot(xs, fi, 'o', lw = 1, marker=1)

plt.show()
"""


#from enthought.chaco.wx import plt
import matplotlib.pyplot as plt
from scipy import arange, optimize, special

plt.figure()
plt.hold()
w = []
z = []
x = arange(0,10,.01)

for k in arange(1,5,.5):
   y = special.jv(k,x)
   plt.plot(x,y)
   f = lambda x: -special.jv(k,x)
   x_max = optimize.fminbound(f,0,6)
   w.append(x_max)
   z.append(special.jv(k,x_max))

plt.plot(w,z, 'ro')
from scipy import interpolate
t = interpolate.splrep(w, z, k=3)
s_fit3 = interpolate.splev(x,t)
plt.plot(x,s_fit3, 'g-')
t5 = interpolate.splrep(w, z, k=5)
s_fit5 = interpolate.splev(x,t5)
plt.plot(x,s_fit5, 'y-')
plt.show()



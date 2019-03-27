import pandas as pd
import matplotlib.pyplot as plt
import pandas_datareader.data as pdr
import datetime
from matplotlib.dates import date2num

data=pdr.get_data_yahoo('^NSEI',start='2016-07-01',end='2017-08-01')
data=pd.DataFrame(data)

pd.concat([data['Close']],axis=1).plot(figsize=(9,5),grid=True)

#plt.plot([100, 100], [200, 200])

def draw_line(sdate, edate, y1, y2):
    p1 = datetime.datetime.strptime(sdate, '%Y-%m-%d')
    p2 = datetime.datetime.strptime(edate, '%Y-%m-%d')

    f1 = date2num(p1)
    f2 = date2num(p2)

    #plt.set_autoscaley_on(True)
    plt.plot_date([f1, f2], [y1, y2], linestyle='-', marker=0)

    #plt.axis([0.0,600.0, 10000.0,20000.0])
    ax = plt.gca()
    ax.set_autoscale_on(True)

draw_line('2016-11-01', '2017-11-01', 7500, 9000)

plt.plot()
plt.show()


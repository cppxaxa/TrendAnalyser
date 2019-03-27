import datetime
from matplotlib.dates import date2num
def preprocess(mydata):
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
    
    return mydata

def getTimeArray(data_with_col):
    data = data_with_col
    timedelta = data - data.min()
    timearray = timedelta.total_seconds() / (24 * 60 * 60)
    return timearray

def get_date_from_str(input):
    p1 = datetime.datetime.strptime(input, '%Y-%m-%d')
    return p1

import pandas as pd
import matplotlib.pyplot as plt
def plot(data, vertical = None, col = 'Close'):
    #plt.axvline(x=0.22058956)
    chart = pd.concat([data[col]],axis=1).plot(figsize=(9,5),grid=True)
    if(vertical != None):
        chart.axvline(x = vertical)
    plt.plot()
    plt.show()

import matplotlib.dates as mdates
def plot_span(data, isdate, iedate, color = 'yellow', col = 'Close'):
    #plt.axvline(x=0.22058956)
    chart = pd.concat([data[col]],axis=1).plot(figsize=(9,5),grid=True)
    chart.axvspan(data.index[isdate], data.index[iedate], color=color, alpha=0.4)
    plt.plot()
    plt.show()



# Define set of lines for the chart
def create_chart(data, col = 'Close'):
    chart = pd.concat([data[col]],axis=1).plot(figsize=(9,5),grid=True)
    return chart

def create_chart_list(data, cols = None):
    if(cols == None):
        return None
    param = []
    for i in range(len(cols)):
        param.append(data[cols[i]])
    chart = pd.concat(param,axis=1).plot(figsize=(9,5),grid=True)
    return chart

def add_span(chart, data, isdate, iedate, color = 'yellow'):
    chart.axvspan(data.index[isdate], data.index[iedate], color=color, alpha=0.4)
    return chart

def plot_chart():
    figManager = plt.get_current_fig_manager()
    figManager.window.showMaximized()

    plt.plot()
    plt.show()

# Color not working
def add_line_with_date(chart, sdate, y1, edate, y2, color = None):
    #sdate = '2015-07-01';
    #edate = '2016-07-01';
    p1 = datetime.datetime.strptime(sdate, '%Y-%m-%d')
    p2 = datetime.datetime.strptime(edate, '%Y-%m-%d')

    f1 = date2num(p1)
    f2 = date2num(p2)

    if(color != None):
        plt.plot([f1, f2], [y1, y2])
    else:
        plt.plot([f1, f2], [y1, y2], color=color)

    return chart

#Over


def delete_col(data, col):
    data.drop(col, axis=1, inplace=True)
    return data

def rename_col(data, from_col, to_col):
    newcols = {
        from_col: to_col
    }
    df.rename(columns=newcols, inplace=True)
    return data


from string import Formatter

def strfdelta(tdelta, fmt='{D:02}d {H:02}h {M:02}m {S:02}s', inputtype='timedelta'):
    """Convert a datetime.timedelta object or a regular number to a custom-
    formatted string, just like the stftime() method does for datetime.datetime
    objects.

    The fmt argument allows custom formatting to be specified.  Fields can 
    include seconds, minutes, hours, days, and weeks.  Each field is optional.

    Some examples:
        '{D:02}d {H:02}h {M:02}m {S:02}s' --> '05d 08h 04m 02s' (default)
        '{W}w {D}d {H}:{M:02}:{S:02}'     --> '4w 5d 8:04:02'
        '{D:2}d {H:2}:{M:02}:{S:02}'      --> ' 5d  8:04:02'
        '{H}h {S}s'                       --> '72h 800s'

    The inputtype argument allows tdelta to be a regular number instead of the  
    default, which is a datetime.timedelta object.  Valid inputtype strings: 
        's', 'seconds', 
        'm', 'minutes', 
        'h', 'hours', 
        'd', 'days', 
        'w', 'weeks'
    """

    # Convert tdelta to integer seconds.
    if inputtype == 'timedelta':
        remainder = int(tdelta.total_seconds())
    elif inputtype in ['s', 'seconds']:
        remainder = int(tdelta)
    elif inputtype in ['m', 'minutes']:
        remainder = int(tdelta)*60
    elif inputtype in ['h', 'hours']:
        remainder = int(tdelta)*3600
    elif inputtype in ['d', 'days']:
        remainder = int(tdelta)*86400
    elif inputtype in ['w', 'weeks']:
        remainder = int(tdelta)*604800

    f = Formatter()
    desired_fields = [field_tuple[1] for field_tuple in f.parse(fmt)]
    possible_fields = ('W', 'D', 'H', 'M', 'S')
    constants = {'W': 604800, 'D': 86400, 'H': 3600, 'M': 60, 'S': 1}
    values = {}
    for field in possible_fields:
        if field in desired_fields and field in constants:
            values[field], remainder = divmod(remainder, constants[field])
    return f.format(fmt, **values)
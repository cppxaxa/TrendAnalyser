import pandas as pd
import matplotlib.pyplot as plt
import matplotlib.dates as mdates
import numpy as np

from preprocess import *

import sys
from matplotlib.dates import date2num
import datetime
from _datetime import timedelta

directory = "D:\\Libraries\\Documents\\Visual Studio 2013\\Projects\\Trend Analyser\\Storage"
filename = "SBIN_2017_8_24_2014_12_1"

if(len(sys.argv) < 4):
    print("python prog.py <directory> <filename> <chart = y/n>")
    exit()

directory = sys.argv[1]
filename = sys.argv[2]
enable_chart = sys.argv[3]

if(enable_chart == 'y'):
    enable_chart = True
else:
    enable_chart = False

mydata = pd.read_csv(directory + "\\" + filename + ".csv", parse_dates=True, index_col=0)
data = preprocess(mydata)


#timearray = getTimeArray(data.index)
#print(timearray)


def findTrendChange(data, col = 'Close', approx_val = 0.2, base_sampling_div_val = 10):
    #step 1
    length = len(data.index)
    j = length - 1
    i = int(length - (length / base_sampling_div_val) - 1)
    subset = data.iloc[i:j]
    subsetTime = range(j - i)
    lastcorr = corr = np.corrcoef(subsetTime, subset[col])[0, 1]
    #print("Correlation: " + str(corr) + ", Len: " + str(j - i) + ", Date: " + str(data.index[i]))

    #step2
    flag = True
    approx = approx_val
    while(i >= 1 and flag):
        i-=1
        subset = data.iloc[i:j]
        subsetTime = range(j - i)
        corr = np.corrcoef(subsetTime, subset[col])[0, 1]
        if(abs(corr - lastcorr) > approx):
            flag = False

    return i, j

def findTrendChange_Fixed_Sampling(data, col = 'Close', approx_val = 0.5, base_sampling = 80):
    #step 1
    length = len(data.index)
    j = length - 1
    i = length - base_sampling - 1

    if(j >= i):
        return i, i

    subset = data.iloc[i:j]
    subsetTime = range(j - i)
    lastcorr = corr = np.corrcoef(subsetTime, subset[col])[0, 1]
    #print("Correlation: " + str(corr) + ", Len: " + str(j - i) + ", Date: " + str(data.index[i]))

    #step2
    flag = True
    approx = approx_val
    while(i >= 1 and flag):
        i-=1
        subset = data.iloc[i:j]
        subsetTime = range(j - i)
        corr = np.corrcoef(subsetTime, subset[col])[0, 1]
        if(abs(corr - lastcorr) > approx):
            flag = False
    return i, j

def addMeanColumn(data, n = 20, col = 'Close', newcol = 'D'):
    arr = data[col].rolling(n).mean()
    SD = data[col].rolling(n).std()
    data["UBB"] = arr + SD * 2
    data[newcol] = arr
    return data


data = addMeanColumn(data, 20)
#print(data['D'])

length = len(data.index)


sampling = 80
diff_val = 0.5
#init chart

chart = None

if(enable_chart):
    chart = create_chart(data)

#chart = create_chart_list(data, ['Close', 'Open'])

color = 'yellow'
segmentedDates = []
segmentedIndexes = []

# Reference points
f_i, f_j = findTrendChange(data, 'UBB')
#print("New Len: " + str(f_j - f_i) + ", Date: " + str(data.index[f_i]))

segmentedDates.append(data.index[f_j])
segmentedDates.append(data.index[f_i])

segmentedIndexes.append(f_j)
segmentedIndexes.append(f_i)

if(enable_chart):
    chart = add_span(chart, data, f_i, f_j, color)

if(color == 'yellow'):
    color = 'red'
else:
    color = 'yellow'


#plot(data, data.index[i])

subset = data.iloc[0:f_i]
i, j = findTrendChange_Fixed_Sampling(subset, 'UBB')

if(i < 0):
    i = 0

#print("i : " + str(i))
if(segmentedIndexes[len(segmentedIndexes) -1] != 0):
    segmentedDates.append(data.index[i])
    segmentedIndexes.append(i)

#print("New Len: " + str(j - i) + ", Date: " + str(data.index[i]))


if(enable_chart):
    chart = add_span(chart, data, i, f_i, color)

if(color == 'yellow'):
    color = 'red'
else:
    color = 'yellow'
f_i = i

#print("Hello")
#print(segmentedIndexes)

k = 0
while(k < 50 and i > sampling):
    subset = data.iloc[0:f_i]
    i, j = findTrendChange_Fixed_Sampling(subset, 'UBB', diff_val, sampling)

    #print(i)
    #print(j)

    segmentedDates.append(data.index[i])
    segmentedIndexes.append(i)

    #print("New Len: " + str(j - i) + ", Date: " + str(data.index[i]))


    if(enable_chart):
        chart = add_span(chart, data, i, f_i, color)

    if(color == 'yellow'):
        color = 'red'
    else:
        color = 'yellow'
    f_i = i
    
    k+=1

if(segmentedIndexes[len(segmentedIndexes) -1] != 0):
    segmentedDates.append(data.index[0])
    segmentedIndexes.append(0)

if(enable_chart):
    plot_chart()





mydata = data.copy()
mydata = delete_col(mydata, 'UBB')
mydata = delete_col(mydata, 'D')

result = mydata.copy()
result = delete_col(result, 'Open')
result = delete_col(result, 'High')
result = delete_col(result, 'Low')
result = delete_col(result, 'Close')
result = delete_col(result, 'Volume')
result = delete_col(result, 'Adj Close')

#print(mydata.loc['9/12/2014'])


length = len(segmentedIndexes)
i = length - 1
j = length - 2
minDate = data.index[0]
#print("MinDate: " + str(minDate))
#date = data.index[2]
#Days
#print(int((date - minDate).days))



df = mydata.iloc[segmentedIndexes[i]:segmentedIndexes[j]]
#print("Length: " + str(len(df.index)))

RsegmentedIndexes = [0]
RsegmentedDates = [data.index[0]]
Rm = [None]
Rc = [None]
RhighC = [None]
from scipy.interpolate import Rbf
RBFFunctions = [None]

timearray = getTimeArray(data.index)

#print("Segmented Index, i, j: " + str(i) + ", " + str(j))
#print(segmentedIndexes)

#last_m, last_c = np.polyfit(np.arange(segmentedIndexes[i], segmentedIndexes[j]), df['Close'], deg=1)
last_m, last_c = np.polyfit(timearray[segmentedIndexes[i]:segmentedIndexes[j]], df['Close'], deg=1)
#Do RBF Here
#print(segmentedIndexes[j] - segmentedIndexes[i])
rbf = Rbf(range(segmentedIndexes[j] - segmentedIndexes[i]), df['Close'])
#print("M, C: " + str(last_m) + ", " + str(last_c))

RsegmentedIndexes.append(segmentedIndexes[j])
RsegmentedDates.append(data.index[segmentedIndexes[j]])
Rm.append(last_m)
Rc.append(last_c)
RhighC.append(df['Close'].std())
RBFFunctions.append(rbf)

i-=1
j-=1


threshold = 0.1
k = 100

#print("Timearray len: " + str(len(timearray)))

while(k > 0 and j >= 0):
    df = mydata.iloc[segmentedIndexes[i]:segmentedIndexes[j]]
    #print("Length: " + str(len(df.index)))

    #m, c = np.polyfit(np.arange(segmentedIndexes[i], segmentedIndexes[j]), df['Close'], deg=1)
    m, c = np.polyfit(timearray[segmentedIndexes[i]:segmentedIndexes[j]], df['Close'], deg=1)
    rbf = Rbf(range(segmentedIndexes[j] - segmentedIndexes[i]), df['Close'])
    mean_range = 2
    rbf = Rbf(range(segmentedIndexes[j] - segmentedIndexes[i] - mean_range), df['Close'].rolling(mean_range).mean()[mean_range:])
    #print("M, C: " + str(m) + ", " + str(c) + "i, j: " + str(segmentedIndexes[i]) + ", " + str(segmentedIndexes[j]) + " ti, tj: " + str(timearray[segmentedIndexes[i]]) + ", " + str(timearray[segmentedIndexes[j]]) + ", " + str(data.index[segmentedIndexes[j]]))

    if(abs(last_m - m) > threshold or j == 0):
        RsegmentedIndexes.append(segmentedIndexes[j])
        # Needs checks here
        RsegmentedDates.append(data.index[segmentedIndexes[j]])
        Rm.append(m)
        Rc.append(c)
        RhighC.append(df['Close'].std())
        RBFFunctions.append(rbf)
        i=j
    
    #i-=1
    j-=1
    
    k-=1

    last_m = m
    last_c = c


#Rm.append(None)
#Rc.append(None)
#RsegmentedIndexes.append(segmentedIndexes[0])
#RsegmentedDates.append(data.index[segmentedIndexes[0]])

def addLinearLines(data, col, m, c):
    timearray = getTimeArray(data.index)
    value = np.multiply(timearray, m) + c
    data[col] = value
    return data

def date_to_timedelta(data, input):
    timedelta = get_date_from_str(input) - data.min()
    timevalue = timedelta.total_seconds() / (24 * 60 * 60)
    return timevalue

def real_date_to_timedelta(data, input):
    timedelta = input - data.min()
    timevalue = timedelta.total_seconds() / (24 * 60 * 60)
    return timevalue


def add_function_line(chart, data, fun, i, j):
    #p1 = datetime.datetime.strptime(sdate, '%Y-%m-%d')
    #p2 = datetime.datetime.strptime(edate, '%Y-%m-%d')

    x = []
    #y = []

    y = fun(range(j - i + 1))

    while i <= j:    
        p1 = data.index[i]

        #sdate = data.index[i].strftime("%Y-%m-%d")
        #sdate = '2016-01-01'
        #p1 = datetime.datetime.strptime(sdate, '%Y-%m-%d')

        f1 = date2num(p1)
        x.append(f1)

        #y.append(50)

        i+=1
    
    #print("Len x: " + str(len(x)))
    #print("Len y: " + str(len(y))) 

    #y = fun(range(j - i + 1))

    #print("Len y: " + str(len(y)))

    plt.plot(x, y)

    return chart


#print("After i")
#print(RsegmentedIndexes)
#print(Rm)
#print(Rc)
#print(RsegmentedDates)

lines = ['Close']
i = 2

if(enable_chart):
    chart = create_chart(data)

while(i < len(RsegmentedIndexes)):
    """
    #Draw all regression lines
    #data = addLinearLines(data, 'LR' + str(i), Rm[i], Rc[i])
    #lines.append('LR' + str(i))
    """

    sdate = RsegmentedDates[i - 1].strftime("%Y-%m-%d");
    edate = RsegmentedDates[i].strftime("%Y-%m-%d");

    y1 = date_to_timedelta(data.index, sdate) * Rm[i] + Rc[i]
    y2 = date_to_timedelta(data.index, edate) * Rm[i] + Rc[i]

    #print("Line Coords: " + str(RsegmentedIndexes[i]) + ", Dates: " + sdate + " to " + edate + ", y1: " + str(int(y1)) + ", y2: " + str(int(y2)))

    if(enable_chart):
        chart = add_line_with_date(chart, sdate, y1, edate, y2, 'g')

        chart = add_line_with_date(chart, sdate, y1 + RhighC[i], edate, y2 + RhighC[i], 'r')
        chart = add_line_with_date(chart, sdate, y1 - RhighC[i], edate, y2 - RhighC[i], 'b')
        #Rbf function
        chart = add_function_line(chart, data, RBFFunctions[i], RsegmentedIndexes[i - 1], RsegmentedIndexes[i])

    i+=1


i = len(RsegmentedIndexes) - 1;
sdate = RsegmentedDates[i - 1].strftime("%Y-%m-%d");
edate = RsegmentedDates[i].strftime("%Y-%m-%d");

x1 = date_to_timedelta(data.index, sdate)
x2 = date_to_timedelta(data.index, edate)

y1 = x1 * Rm[i] + Rc[i]
y2 = x2 * Rm[i] + Rc[i]

# RBFFunctions[i], RsegmentedIndexes[i - 1], RsegmentedIndexes[i]
rbf = RBFFunctions[i]

#print(sdate + " " + str(x1))
#print(edate + " " + str(x2))


#print("get last 4 data")
x = [ 
    real_date_to_timedelta(data.index, data.index[RsegmentedIndexes[i]] ),
    real_date_to_timedelta(data.index, data.index[RsegmentedIndexes[i] - 1]),
    real_date_to_timedelta(data.index, data.index[RsegmentedIndexes[i] - 2]),
    real_date_to_timedelta(data.index, data.index[RsegmentedIndexes[i] - 3])
    ]

y = [ 
    data.Close[RsegmentedIndexes[i]],
    data.Close[RsegmentedIndexes[i] - 1],
    data.Close[RsegmentedIndexes[i] - 2],
    data.Close[RsegmentedIndexes[i] - 3]
    ]

#print(x)
#print(y)

#print("Now predict")

edate_index = x[0]

closing_price = data.Close[RsegmentedIndexes[i]]
current_date = data.index[RsegmentedIndexes[i]]


# Iteration limits
min_j = RsegmentedIndexes[i - 1]
max_j = j = RsegmentedIndexes[i]

print("Iteration Limits")
print("min_j")
print(data.index[min_j])
print("max_j")
print(data.index[max_j])

# Find max in the segment
j = RsegmentedIndexes[i]
max_price = data.Close[j]
max_price_index = j
while j > min_j:
    j-=1
    if max_price < data.Close[j]:
        max_price = data.Close[j]
        max_price_index = j

print("Max price " + str(max_price) + ", index: " + str(max_price_index))
#print(data.index[max_price_index])


# Now check lowest point after
j = max_price_index
min_price_right = data.Close[j]
min_price_index_right = j
while j < max_j:
    j+=1
    if min_price_right > data.Close[j]:
        min_price_right = data.Close[j]
        min_price_index_right = j


# Now check lowest point before
j = max_price_index
min_price_left = data.Close[j]
min_price_index_left = j
while j > min_j:
    j-=1
    if min_price_left > data.Close[j]:
        min_price_left = data.Close[j]
        min_price_index_left = j



print("Min price indexes")
print(str(min_price_index_left) + " " + str(min_price_left))
print(str(min_price_index_right) + " " + str(min_price_right))

# Which is minimum
try:
    date_range_left = data.index[max_price_index] - data.index[min_price_index_left]
    date_range_right = data.index[min_price_index_right] - data.index[max_price_index]

    expected_avg_days = (date_range_left.days + date_range_right.days) / 2

    print("Min prices left and right: " + str(min_price_left) + ", " + str(min_price_right))

    print("#Expected_Days," + str(expected_avg_days))

    predicted_date = get_date_from_str(edate) + timedelta(days = expected_avg_days)
    predicted_date_str = str(predicted_date.year) + '-' + str(predicted_date.month) + '-' + str(predicted_date.day)
    print("#Predicted_Date," + predicted_date_str)
    print("#Closing_Price," + str(closing_price))
    print("#Predicted_Price," + str(max_price))
    print("#Profit," + str(max_price - closing_price))
    print("#Profit_Percentage," + str((max_price - closing_price) * 100 / closing_price))
    print("#Trend," + str(Rm[i]))
except:
    print("#Not_possible")


"""
j = edate_index + 1
targetv = max_price
currentv = j * z[0] + z[1]
maxlim = j + 1000
while(currentv < targetv and j < maxlim):
    j+=1
    currentv = j * z[0] + z[1]


print("Regression")
print(str(Rm[i]) + " " + str(Rc[i]))
print(str(z[0]) + " " + str(z[1]))

predicted_date = get_date_from_str(edate) + timedelta(days = (j - edate_index))
predicted_date_str = str(predicted_date.year) + '-' + str(predicted_date.month) + '-' + str(predicted_date.day)
print("#Predicted_Date," + predicted_date_str)

print("#Closing_Price," + str(closing_price))
#print(closing_price)

print("#Predicted_Price," + str(targetv))

days_to_go = predicted_date - current_date
print("#Days_To_Go," + str(days_to_go.days))
"""



"""
#Draw all regression lines
chart = create_chart_list(data, lines)
"""

if(enable_chart):
    plot_chart()



#print(RsegmentedIndexes)
#print(Rm)


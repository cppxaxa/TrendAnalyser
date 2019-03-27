"""

import pandas_datareader.data as pdr
import pandas as pd
import matplotlib.pyplot as plt



#define each and everything to perform the operation
def PPSR(data):  
    PP = pd.Series((data['High'] + data['Low'] + data['Close']) / 3)  
    R1 = pd.Series(2 * PP - data['Low'])  
    S1 = pd.Series(2 * PP - data['High'])  
    R2 = pd.Series(PP + data['High'] - data['Low'])  
    S2 = pd.Series(PP - data['High'] + data['Low'])  
    R3 = pd.Series(data['High'] + 5 * (PP - data['Low']))  
    S3 = pd.Series(data['Low'] - 5 * (data['High'] - PP))  
    psr = {'PP':PP, 'R1':R1, 'S1':S1, 'R2':R2, 'S2':S2, 'R3':R3, 'S3':S3}  
    PSR = pd.DataFrame(psr)  
    data= data.join(PSR)  
    return data
#extract the stock data
data = pdr.get_data_yahoo("^NSEI", start="2017-01-01", end="2017-07-31")
#compute and print the data
PD = LL = PPSR(data)
print(LL)
# plot the data
pd.concat([data['Close'],PD.PP,PD.R1,PD.S1,PD.R2,PD.S2,PD.R3,PD.S3],axis=1).plot(figsize=(12,9),grid=True)
plt.show()

"""

import pandas as pd
import matplotlib.pyplot as plt
import matplotlib.dates as mdates
import numpy as np

from preprocess import *

import sys

directory = "D:\\Libraries\\Documents\\Visual Studio 2013\\Projects\\Trend Analyser\\Storage"
filename = "SBIN_2017_8_24_2014_12_1"

if(len(sys.argv) < 3):
    print("python prog.py <directory> <filename>")
    exit()

directory = sys.argv[1]
filename = sys.argv[2]

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
    print("Correlation: " + str(corr) + ", Len: " + str(j - i) + ", Date: " + str(data.index[i]))

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
    print("Correlation: " + str(corr) + ", Len: " + str(j - i) + ", Date: " + str(data.index[i]))

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
    data[newcol] = arr
    return data


data = addMeanColumn(data, 20)
#print(data['D'])

length = len(data.index)


sampling = 80
diff_val = 0.5
#init chart
chart = create_chart(data)
color = 'yellow'


# Reference points
f_i, f_j = findTrendChange(data, 'Close')
print("New Len: " + str(f_j - f_i) + ", Date: " + str(data.index[f_i]))

chart = add_span(chart, data, f_i, f_j, color)
if(color == 'yellow'):
    color = 'red'
else:
    color = 'yellow'


#plot(data, data.index[i])


subset = data.iloc[0:f_i]
i, j = findTrendChange_Fixed_Sampling(subset, 'Close')

print("New Len: " + str(j - i) + ", Date: " + str(data.index[i]))



chart = add_span(chart, data, i, f_i, color)
if(color == 'yellow'):
    color = 'red'
else:
    color = 'yellow'
f_i = i


k = 0
while(k < 50 and i > sampling):
    subset = data.iloc[0:f_i]
    i, j = findTrendChange_Fixed_Sampling(subset, 'D', diff_val, sampling)

    print("New Len: " + str(j - i) + ", Date: " + str(data.index[i]))


    chart = add_span(chart, data, i, f_i, color)
    if(color == 'yellow'):
        color = 'red'
    else:
        color = 'yellow'
    f_i = i

    k+=1


plot_chart()

#while(i > 0):
#    pDate.append(data.index[i])
#    pY.append(data['Close'][i])
#    subset = data.iloc[0:i]
#    i, j = findTrendChange(subset, 'D')
#    print("New Len: " + str(j - i) + ", Date: " + str(data.index[i]))







#pd.concat([mydata.Close],axis=1).plot(figsize=(9,5),grid=True)

#figManager = plt.get_current_fig_manager()
#figManager.window.showMaximized()

#plt.plot()
#plt.show()


"""
df = pd.read_csv('test.csv')
df['date'] = pd.to_datetime(df['date'])    
df['date_delta'] = (df['date'] - df['date'].min())  / np.timedelta64(1,'D')
city_data = df[df['city'] == 'London']
result = sm.ols(formula = 'sales ~ date_delta', data = city_data).fit()
"""
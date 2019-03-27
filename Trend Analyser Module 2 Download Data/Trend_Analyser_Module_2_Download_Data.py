from datetime import date
from nsepy import get_history

import sys

i = 3

if(len(sys.argv) < 9):
    print("argv: location symbol syear smonth sday eyear emonth eday")
else:
    location = sys.argv[i - 2]
    symbol = sys.argv[i - 1]
    syear, smonth, sday = int(sys.argv[i]), int(sys.argv[i + 1]), int(sys.argv[i + 2])
    eyear, emonth, eday = int(sys.argv[i + 3]), int(sys.argv[i + 4]), int(sys.argv[i + 5])

    fname = location + "\\" + symbol + "_" + str(eyear) + "_" + str(emonth) + "_" + str(eday) + "_" + str(syear) + "_" + str(smonth) + "_" + str(sday) + ".csv"
    
    try:
        startdate = date(syear, smonth, sday)
        enddate = date(eyear, emonth, eday)

        dataset = get_history(symbol=symbol,
                            start=startdate,
                            end=enddate)

        dataset.to_csv(fname, index=True, header=True, sep=',')

    except:
        print("Error occurred while downloading. Please check your internet connection or contact administrator.\nModule 2")

    else:
        print("Successful Download")


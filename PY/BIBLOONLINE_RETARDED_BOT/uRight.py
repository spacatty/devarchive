import os
import requests
import re
import datetime
import cfscrape
import random

scraper = cfscrape.create_scraper()
now = datetime.datetime.now()
siteURL = "https://biblio-online.ru/"
postURL = "https://biblio-online.ru/register"
FilePattern = "LogFrom {}-{}.txt".format(now.day, now.hour)

def doPost():
    UAS = ("Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1", 
       "Mozilla/5.0 (Windows NT 6.3; rv:36.0) Gecko/20100101 Firefox/36.0",
       "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10; rv:33.0) Gecko/20100101 Firefox/33.0",
       "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36",
       "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2227.1 Safari/537.36",
       "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2227.0 Safari/537.36",
       )

    ua = UAS[random.randrange(len(UAS))]

    headers = {"User-Agent": ua}

    data =    {
                "role": "9",
                "email": "hellofromthere1@gmail.com",
                "agree_news": "yes",
                "agree": "yes"
               }
    sendRegistration = scraper.post(postURL, data=data, headers=headers)
    print(sendRegistration.text)

def doErr():
    print('ERR')

def getSoupedThreads(iterrationsCount):
    content = scraper.get("https://biblio-online.ru/")
    if content.status_code == 200:
        print('Session updated successfully')
        doPost()
    else:
        doErr()
    return

print('Количество иттераций: ')
getSoupedThreads(int(input()))

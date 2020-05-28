import os
import http.cookiejar
import requests
import re
import datetime

now = datetime.datetime.now()
FilePattern = "LogFrom {}-{}.txt".format(now.day, now.hour)


def getSoupedThreads():
    SuccessFile = open(FilePattern, "w+")
    cj = http.cookiejar.MozillaCookieJar(
        '/Users/anxietyangst/Desktop/Devilopment/pyLolzBot/cookie.txt')
    cj.load()
    contests = requests.get(
        "https://lolzteam.net/forums/contests/", cookies=cj)
    threadPattern = re.compile('id=\"thread-(.*?)\"')
    threadNumbersList = threadPattern.findall(contests.text)
    for threadItem in threadNumbersList:

        contestThreadContent = requests.get(
            'https://lolzteam.net/threads/' + threadItem, cookies=cj)
        confirmationTokenPattern = re.compile("participate\?_xfToken=(.*?)\"")
        confirmationToken = confirmationTokenPattern.findall(
            contestThreadContent.text)
        if len(confirmationToken) > 0:
            PartURL = ("https://lolzteam.net/threads/{}/participate?_xfToken={}".format(
                threadItem, ''.join(confirmationToken)))

            headers = {"User-Agent": "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36",
                            "Content-Type": "application/x-www-form-urlencoded; charset=UTF-8",
                            "Accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3"}
            data = {
                "_xfRequestUri": "/threads/{}/".format(threadItem),
                "_xfNoRedirect": "1",
                "_xfToken": "".join(confirmationToken),
                "_xfResponseType": "json"
            }

            ParticipatePOST = requests.get(PartURL, headers=headers, data=data, cookies=cj)
            SuccessFile.write("DONE -> " + PartURL + "\n")
            print("{} - succeded -> {}".format(threadItem, ParticipatePOST.status_code))
        else:
            SuccessFile.write("DONE -> " + PartURL + "\n")
            print("{} - already".format(threadItem))



getSoupedThreads()

#!/bin/env python

from urllib.request import urlopen
html = urlopen("http://www.mapcloud.co.kr")
print(html.read())

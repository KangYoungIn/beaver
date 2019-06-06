#!/bin/env python

from urllibe.reaquest import urlopen
from bs4 import BeautifulSoup
html = urlopen("http://www.mapcloud.co.kr")
bs0bj = BeautifulSoup(html.read(), "html.parser")
print(bs0bj.h1)

#!/bin/env python

from urllib.request import urlopen
from bs4 import BeautifulSoup
html = urlopen("http://www.mapcloud.co.kr")
bs0bj = BeautifulSoup(html.read(), "html.parser")
print(bs0bj.h1)

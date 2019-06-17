#!/bin/env python3

from slacker import Slacker

slack_token = 'xoxb-661033479312-669602164646-B0sKGpFOEbFrSvDgQVa59d9l'
slack = Slacker(slack_token)
slack.chat.post_message('#toy-project','챗봇테스트입니다.')

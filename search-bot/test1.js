const botkit = require('botkit');
const slack = require('slack-node');
const { RTMClient } = require('@slack/client');
const token = process.env.SLACK_TOEKN || 'xoxb-661033479312-661839074306-QZ6jZeWifUxP9601wymXulXy';
const rtm = new RTMClient(token);
rtm.start();

rtm.on('message',(messsage) => {
    var test = message.text
});

function convert(test) {
    return "https://www.google.co.kr/serach?q=" + test;
}

const controller = botkit.slackbot({
    debug:false,
    log:true
});

const botScope = [
    'direct_message',
    'direct_mention',
    'mention'
];

const convertmessage = convert(test)

controller.hears(test, botScope, (bot, message) => {
    bot.reply(message, convertmessage);
});

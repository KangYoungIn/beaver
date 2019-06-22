const { RTMClient } = require('@slack/client');
const token = process.env.SLACK_TOKEN || 'xoxb-661033479312-661839074306-QZ6jZeWifUxP9601wymXulXy';
const rtm = new RTMClient(token);
rtm.start();

rtm.on('message',(message) => {
    const text = message.text
    if (text.includes(' ')) {
        const text2 = text.replace(/ /gi, "+");
        rtm.sendMessage("https://www.google.co.kr/search?q=" + text2, message.channel);
    }
    else {rtm.sendMessage("https://www.google.co.kr/search?q=" + text, message.channel);
    }
});

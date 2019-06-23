const { RTMClient } = require('@slack/client');
const { WebClient } = require('@slack/client');
const convert = require("./query.js").convert;
const dotenv = require('dotenv');
const token = process.env.TOKEN;

if (!token) {
    console.log('토큰이 올바르게 동작하지 않습니다.');
    process.exitCode = 1;
    return;
}

const rtm = new RTMClient(token);
const web = new WebClient(token);
rtm.start();

/**
rtm.on('message',(message) => {
    const text = message.text
    if (text.includes('검색!'){
        if (text.includes(' ')){
            const text2 = text.replace(/ /gi, "+");
            rtm.sendMessage("https://www.google.co.kr/search?q=" + text2, message.channel);
        }
        else {
            rtm.sendMessage("https://www.google.co.kr/search?q=" + text, message.channel);
        }
    }
    else {
        return;
        }
});
**/
rtm.on('message', (message) => {
    if(!message.text.includes("검색!")){
        return;
    }
    let queryURI = convert(message.text);
    if(queryURI){
        web.chat.postMessage({
            channel : message.channel,
            text : queryURI,
            as_user : true
        });
    }
});

//날씨검색을 위한 API KEY 정의
const lat1 = 37.536474; //강영인위도
const long1 = 127.136067;  //강영인경도
const lat2 = 37.511906; //윤지원위도
const long2 = 126.852236; //윤지원경도
const weather_key = "4f4e4dc58fbb0eff96c49739ee97bed3";
const request = require('request');

//날씨정보 수신 기능 정의
function weather1(callback) {
    request(`https://api.darksky.net/forecast/${weather_key}/${lat1},${long1}?lang=ko&units=si`,{json:true},(err,res,body) => {
        if (err) {return console.log(err);}
        var w1 = body.currently.summary
        var w2 = body.currently.temperature + "º"
        var w3 = body.currently.humidity * 100 + "%"
        var weatherValue = "강영인님 집 위치 기준 현재날씨정보입니다." + "\n날씨:" + w1 + "\n기온:" + w2 + "\n습도:" + w3
        callback(weatherValue);
        });
    };

function weather2(callback) {
    request(`https://api.darksky.net/forecast/${weather_key}/${lat2},${long2}?lang=ko&units=si`,{json:true},(err,res,body) => {
        if (err) {return console.log(err);}
        var w1 = body.currently.summary
        var w2 = body.currently.temperature + "º"
        var w3 = body.currently.humidity * 100 + "%"
        var weatherValue = "윤지원님 집 위치 기준 현재날씨정보입니다." + "\n날씨:" + w1 + "\n기온:" + w2 + "\n습도:" + w3
        callback(weatherValue);
        });
    };

function weather3(callback) {
    request(`https://api.darksky.net/forecast/${weather_key}/37.517910,126.990758?lang=ko&units=si`,{json:true},(err,res,body) => {
        if (err) {return console.log(err);}
        var w1 = body.currently.summary
        var w2 = body.currently.temperature + "º"
        var w3 = body.currently.humidity * 100 + "%"
        var w4 = body.daily.summary
        var weatherValue = "서울 날씨 정보입니다." + "\n현재날씨:" + w1 + "\n현재기온:" + w2 + "\n현재습도:" + w3+ "\n일일날씨요약:" + w4
        callback(weatherValue);
        });
    };

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

rtm.on('message',(message) => {
    if(message.text.includes("요니네날씨")){
        weather1(function(body){rtm.sendMessage(body,message.channel);})
       }

    if(message.text.includes("됴니네날씨")){
        weather2(function(body){rtm.sendMessage(body,message.channel);})
       }
    
    if(message.text.includes("서울날씨")){
        weather3(function(body){rtm.sendMessage(body,message.channel);})
       }
});

rtm.on('message', (message) => {
    if(!message.text.includes("구글:")){
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

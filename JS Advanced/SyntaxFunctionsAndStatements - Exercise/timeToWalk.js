'use strict'

function timeToWalk(stepsCount, meters, speed) {
    let distance = stepsCount * meters;
    let speedInSec = speed / 3.6;
    let time = distance / speedInSec;
    let rest = Math.floor(distance / 500);

    let timeInH = Math.floor(time /3600);
    let timeInMin = Math.floor(time / 60);
    let timeInSec = Number((time - (timeInMin * 60)).toFixed(0));
    timeInMin += rest;
    timeInH  += Math.floor(timeInMin / 60);
    timeInMin = timeInMin % 60;

    let formattedHour = timeInH < 10 ? `0${timeInH}` : `${timeInH}`;
    let formattedMin = timeInMin < 10 ? `0${timeInMin}` : `${timeInMin}`;
    let formattedSec = timeInSec < 10 ? `0${timeInSec}` : `${timeInSec}`;

    console.log(`${formattedHour}:${formattedMin}:${formattedSec}`)
}

timeToWalk(4000, 0.60, 5);
console.log('-------------')
timeToWalk(2564, 0.70, 5.5);
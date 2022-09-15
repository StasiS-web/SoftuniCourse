'use strict'

function roadRadar(currSpeed, area) {
    let speedLimit = 0;
    let result = null;

    switch(area) {
        case 'motorway': 
            speedLimit = 130;
            break;
        case 'interstate': 
            speedLimit = 90;
            break;
        case 'city':
            speedLimit = 50;
            break;
        case 'residential':
            speedLimit = 20;
            break;
    }

    if (currSpeed > speedLimit){
        let status = null;
        let difference = Math.abs(currSpeed - speedLimit);
            
        if (difference <= 20) {
            status = 'speeding';
        }
        else if (difference <= 40) {
            status = 'excessive speeding';
        }
        else {
            status = 'reckless driving';
        }
    
        result =`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - ${status}`;
    }
    else {
        result = `Driving ${currSpeed} km/h in a ${speedLimit} zone`;
    }

    console.log(result);
}

roadRadar(40, 'city');
console.log('-------------')
roadRadar(21, 'residential');
console.log('-------------')
roadRadar(120, 'interstate');
console.log('-------------')
roadRadar(200, 'motorway')

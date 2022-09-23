'use strict'

function townsToJSON(array) { 
    let result = [];
    array.shift();
    for (let town of array) {
        let item = town.slice(2, town.length-2)
        let [townName, lat, long ] = item.split(' | ');
        let obj ={
            'Town': townName,
            'Latitude': Number(Number(lat).toFixed(2)),
            'Longitude': Number(Number(long).toFixed(2))
        };

        result.push(obj);
    }

    console.log(JSON.stringify(result));
}

townsToJSON(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']);
console.log('-------------')
townsToJSON(['| Town | Latitude | Longitude |',
'| Veliko Turnovo | 43.0757 | 25.6172 |',
'| Monatevideo | 34.50 | 56.11 |']);
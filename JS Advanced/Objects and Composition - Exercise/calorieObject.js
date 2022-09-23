'use strict'

function calorieObject(array) {
    let foodData = {};

    for(let i = 0; i < array.length; i+=2) {
        const name = array[i];
        const calories = Number(array[i + 1]);
        foodData[name] = calories;
    }

    console.log(foodData);
}

calorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
console.log('-------------')
calorieObject(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);
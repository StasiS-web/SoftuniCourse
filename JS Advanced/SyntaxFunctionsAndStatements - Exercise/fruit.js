'use strict'

function fruit(fruit, grams, price) {
    let weight = grams / 1000;
    let money = weight * price;
    
    console.log(`I need ${money} to buy ${weight} kilograms ${fruit}.`)
}

fruit('orange', 2500, 1.80);
console.log('-------------')
fruit('apple', 1563, 2.35);
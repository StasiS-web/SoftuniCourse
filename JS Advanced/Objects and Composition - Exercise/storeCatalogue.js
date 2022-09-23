'use strict'

function storeCatalogue(arrayOfProducts) {
    let sortedProduct = arrayOfProducts.sort((a, b) => a.localeCompare(b));
    let firstChar = '';
    let result = {};

   for(let ele of sortedProduct) {
      let [product, price] = ele.split(' : ');
      result[product] = price;

      if(ele[0] !== firstChar) {
          console.log(ele[0]);
      }

      console.log(`  ${product}: ${result[product]}`);

      firstChar = ele[0];
    }
}

storeCatalogue(['Appricot : 20.4',
                'Fridge : 1500', 'TV : 1499', 
                'Deodorant : 10', 
                'Boiler : 300', 
                'Apple : 1.25', 
                'Anti-Bug Spray : 15', 
                'T-Shirt : 10']);
console.log('-------------')
storeCatalogue(['Banana : 2', 
                'Rubic\'s Cube : 5', 
                'Raspberry P : 4999', 
                'Rolex : 100000', 
                'Rollon : 10', 
                'Rali Car : 2000000', 
                'Pesho : 0.000001', 
                'Barrel : 10']);
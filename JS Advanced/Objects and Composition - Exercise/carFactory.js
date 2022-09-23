'use strict'

function carFactory(data) {
   let car = {};

   car = {
        model: data.model,
        engine: checkEngine(data.power),
        carriage: checkCarriage(),
        wheels: car.wheels
   };

   function checkEngine(power) {

       if(power <= 90) {
           return car.engine = { power: 90, volume: 1800 };
       }
       else if(power > 90 && power <= 120) {  
           return car.engine = { power: 120, volume: 2400 };
       }
       else {
          return car.engine = { power: 200, volume: 3500 };
       }
   }

   function checkCarriage() {
        let carriageEnum = {
            hatchback: function(color) { 
                    return { 
                        type: 'hatchback', 
                        color }
                },
                coupe: function(color) { 
                return { 
                        type: 'coupe', 
                        color }
                }
            };
        
        return carriageEnum[data.carriage](data.color);
   }
       
   if (Number(data.wheelsize) % 2 === 0) {
       car.wheels = Number(data.wheelsize) - 1;
   }
   else {
    car.wheels = Number(data.wheelsize);
   }
   
    car.wheels = new Array(4).fill(car.wheels); 

   // console.table(car);
   return car;
}

console.log(carFactory({model: 'VW Golf II', 
            power: 90, 
            color: 'blue', 
            carriage: 'hatchback', 
            wheelsize: 14}));
console.log('-------------')
console.log(carFactory({model: 'Opel Vectra', 
            power: 110, 
            color: 'grey', 
            carriage: 'coupe', 
            wheelsize: 17}));

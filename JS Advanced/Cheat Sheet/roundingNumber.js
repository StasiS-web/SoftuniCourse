// 1. Rounds up and returns the smaller integer greater than or equal to a given number.
let upNum = Math.ceil(45.15); // upNum = 46

// 2. Rounds down and returns the largest integer less than or equal to a given number
let downNum = Math.floor(45.67); // downNum = 45

// 3. function returns the integer part of a number by removing any fractional digits.
let trunc = Math.trunc(45.67);  // trunc = 45

// 4. function returns the value of a number rounded to the nearest integer. 
// If the fractional portion of the argument is greater than 0.5, the argument is rounded 
// to the integer with the next higher absolute value. 
// If it is less than 0.5, the argument is rounded to the integer with the lower absolute value. 
//If the fractional portion is exactly 0.5, the argument is rounded to the next integer.
Math.round(5.439);     // 5
Math.round(5.539);    //6
Math.round(20.49);   // 20

// 6. method returns the value of a base raised to a power
// Math.pow() is equivalent to the ** operator, except Math.pow() only accepts numbers.
Math.pow(7, 3);        //343
Math.pow(4, 0.5);     // 2
Math.pow(-7, 0.5);    // NaN

// 7. function returns a floating-point, pseudo-random number that's greater than or 
// equal to 0 and less than 1, with approximately uniform distribution over that range — which you can then scale to your desired range.
// Getting random number between two value

function getRandomArbitrary(min, max) {
    return Math.random() * (max - min) + min;
  }

  // 8. function returns the square root of a number. 
  Math.sqrt(2);    // 1.414213562373095
  Math.sqrt(9);    // 3
  Math.sqrt(-1);   //NaN